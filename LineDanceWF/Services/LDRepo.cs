using LineDanceWF.Data;
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

        public void DemoMetod()
        {
            // Prata med injectad dbcontext
            var x = _db.Songs;
        }

        public void AddSong(Song song)
        {
            _db.Songs.Add(song);
            _db.SaveChanges();
        }
        public void AddSongs(List<Song> songs)
        {
            foreach(Song song in songs)
            {
                _db.Songs.Add(song);
            }
            _db.SaveChanges();
        }

        public void DeleteSong(Song song)
        {
            _db.Songs.Remove(song);
            _db.SaveChanges();
        }
        public void EditSong(Song song)
        {
            _db.Songs.Update(song);
            _db.SaveChanges();
        }
        public void AddDance(Dance dance)
        {
            _db.Dances.Add(dance);
            _db.SaveChanges();
        }
        public void DeleteDance(Dance dance)
        {
            _db.Dances.Remove(dance);
            _db.SaveChanges();
        }
        public void EditDance(Dance dance)
        {
            _db.Dances.Update(dance);
            _db.SaveChanges();
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
                        if (_db.Songs.Where(x => x.FileHash.Equals(song.FileHash)).Count() ==0)
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
