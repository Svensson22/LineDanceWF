using LineDanceWF.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace LineDanceWF.Services
{
    internal class LDRepo
    {
        private LDContext _db;

        public LDRepo(LDContext db)
        {
            _db = db;
        }

        public Song DemoMetod()
        {
            // Prata med injectad dbcontext
            return _db.Songs.FirstOrDefault();
        }

        public Song? GetSongByName(string name)
        {
            return _db.Songs.Where(x => x.Name == name).FirstOrDefault();
        }

        public void AddSong(Song song)
        {
            if (_db.Songs.Where(x => x.FileHash.Equals(song.FileHash)).Count() != 0)
            {
                _db.Songs.Add(song);
                _db.SaveChanges();
            }
            else
            {
                SongExist(song);
            }
        }
        //Need to have exist checks when making the list
        //before the call of this one
        public void AddSongs(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                _db.Songs.Add(song);
            }
            _db.SaveChanges();
        }

        public void DeleteSong(Song song)
        {
            if (_db.Songs.Where(x => x.FileHash.Equals(song.FileHash)).Count() != 0)
            {
                _db.Songs.Remove(song);
                _db.SaveChanges();
            }
            else
            {
                SongNotExist(song);
            }
        }
        public void EditSong(Song song)
        {
            if (_db.Songs.Where(x => x.FileHash.Equals(song.FileHash)).Count() != 0)
            {
                _db.Songs.Update(song);
                _db.SaveChanges();
            }
            else
            {
                SongNotExist(song);
            }
        }
        public List<Song> FindTop20songs(string searchStr)
        {
            try
            {
                List<Song> list = new List<Song>();
                list = _db.Songs.Where(x => x.Name.ToLower().Contains(searchStr.ToLower())).Take(20).ToList();
                return list;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                List<Song> list = new List<Song>();
                return list;
            }
        }

        public void AddDance(Dance dance)
        {
            try
            {
                if (_db.Dances.Where(x => x.Name.Equals(dance.Name)).Count() == 0)
                {
                    _db.Dances.Add(dance);
                    _db.SaveChanges();
                }
                else
                {
                    DanceExist(dance);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DanceExist(Dance dance)
        {
            MessageBox.Show($"{dance.Name} already exist, please enter another one");
        }
        public void DanceNotExist(Dance dance)
        {
            MessageBox.Show($"{dance.Name} Don't exist, please enter another one");
        }
        public void SongExist(Song song)
        {
            MessageBox.Show($"{song.Name} already exist, please enter another one");
        }
        public void SongNotExist(Song song)
        {
            MessageBox.Show($"{song.Name} Don't exist, please enter another one");
        }


        public void DeleteDance(Dance dance)
        {
            try
            {
                if (_db.Dances.Where(x => x.Name.Equals(dance.Name)).Count() != 0)
                {
                    _db.Dances.Remove(dance);
                    _db.SaveChanges();
                }
                else
                {
                    DanceNotExist(dance);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void EditDance(Dance dance)
        {
            try
            {
                if (_db.Dances.Where(x => x.Name.Equals(dance.Name)).Count() != 0)
                {
                    _db.Dances.Update(dance);
                    _db.SaveChanges();
                }
                else
                {
                    DanceNotExist(dance);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<Dance> FindTop20dances(string searchStr)
        {
            try
            {
                List<Dance> list = new List<Dance>();
                list = _db.Dances.Where(x => x.Name.ToLower().Contains(searchStr.ToLower())).Include(x => x.Alternatives).Include(x => x.OriginalSong).Take(20).ToList();
                return list;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                List<Dance> list = new List<Dance>();
                return list;
            }
        }


        public string FolderPicker()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                return fbd.SelectedPath;
            }
        }
        public void AddSongsFromFolder()
        {
            MessageBox.Show("You need to chose a default folder to import files from.");
            AddSongsFromFolder(FolderPicker());
        }
        public void AddSongsFromFolder(string path)
        {
            try
            {
                List<Song> songs = new List<Song>();
                int AmountOfNewSongs = 0;
                int AmountOfExistingSongs = 0;

                foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        string ext = Path.GetExtension(file);
                        //Searching for files with the extension we want to be able to play
                        if (ext == ".mp3" || ext == ".m4a" || ext == ".wav" || ext == ".ogg")
                        {
                            Song song = new Song()
                            {
                                Name = Path.GetFileName(file),
                                FilePath = Path.GetFullPath(file),
                                FileHash = GetHash(Path.GetFullPath(file)),
                            };
                            if (_db.Songs.Where(x => x.FileHash.Equals(song.FileHash)).Count() == 0)
                            {
                                songs.Add(song);
                                AmountOfNewSongs++;
                            }
                            else
                            {
                                AmountOfExistingSongs++;
                            }
                        }
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        MessageBox.Show(e.Message);
                        continue;
                    }
                    catch (System.IO.DirectoryNotFoundException e)
                    {
                        MessageBox.Show(e.Message);
                        continue;
                    }
                }
                AddSongs(songs);
                MessageBox.Show($"{AmountOfNewSongs} new songs added. \n{AmountOfExistingSongs} existing songs found and were skipped.");

            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message + "\nPlease pick a folder that you have acess to");
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }

        }


        //Think this should work for getting the hash
        private string GetHash(string filepath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filepath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream));
                }
            }
        }
    }
}
