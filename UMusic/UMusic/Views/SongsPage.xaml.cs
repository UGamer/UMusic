using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

using UMusic.Core.Models;
using UMusic.Core.Services;

using Windows.Storage;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace UMusic.Views
{
    public sealed partial class SongsPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Song> Source { get; } = new ObservableCollection<Song>();

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on SongsPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public SongsPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Source.Clear();

            // TODO WTS: Replace this with your actual data

            //string[] tempPaths = { @"E:\Music\Google Drive (ijustwannaseemyfamily@gmail.com)\music (1)\", @"E:\Music\Google Drive (ijustwannaseemyfamily@gmail.com)\music (1)\download\" };
            string[] tempPaths = { @"C:\Users\itsug\Music\" };

            ArrayList files = new ArrayList();

            /*
            foreach (string path in tempPaths)
            {
                string[] pathFiles = Directory.GetFiles(path);

                foreach (string pathFile in pathFiles)
                {
                    files.Add(pathFile);
                }
            }
            */

            var musicLibrary = await StorageLibrary.GetLibraryAsync(KnownLibraryId.Music);
            Console.WriteLine(musicLibrary.SaveFolder.Path);

            files.Add(@"E:\Music\Google Drive (ijustwannaseemyfamily@gmail.com)\music (1)\download\ILLENIUM - Good Things Fall Apart (Tiesto Remix) ft. Jon Bellion.mp3");

            Song song;
            TagLib.File tagFile;
            foreach (var file in files)
            {
                song = new Song();

                tagFile = TagLib.File.Create(file.ToString());

                if (tagFile.Tag.Title == null)
                {
                    string fileName = file.ToString();
                    for (bool ready = false; ready == false;)
                    {
                        int folderIndex = fileName.IndexOf("\\");
                        if (folderIndex != -1)
                        {
                            fileName = fileName.Substring(folderIndex + 1);
                        }
                        else
                        {
                            fileName = fileName.Substring(0, fileName.Length - 4);
                            ready = true;
                        }
                    }
                    song.Title = fileName;
                }
                else
                {
                    song.Title = tagFile.Tag.Title;
                }

                song.Artist = tagFile.Tag.FirstPerformer;
                song.Album = tagFile.Tag.Album;
                song.AlbumArtist = tagFile.Tag.FirstAlbumArtist;
                song.Genre = tagFile.Tag.FirstGenre;
                song.FileCreated = File.GetCreationTime(file.ToString());
                song.FilePath = file.ToString();

                Source.Add(song);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
