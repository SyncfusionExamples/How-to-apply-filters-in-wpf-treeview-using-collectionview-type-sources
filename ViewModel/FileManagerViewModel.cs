using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SfTreeViewDemo
{
    public class FileManagerViewModel : NotificationObject
    {
        #region Fields

        private ObservableCollection<FileManager> imageNodeInfo;

        public CollectionView CollectionView { get; set; }

        public object Item { get; set; }
        #endregion

        #region Constructor

        public FileManagerViewModel()
        {
            GenerateSource();
            CollectionView = new ListCollectionView(ImageNodeInfo);
        }

        #endregion

        #region Filtering
        internal delegate void FilterChanged();
        internal FilterChanged filterChanged;

        private string filterText = string.Empty;

        public string FilterText
        {
            get { return filterText; }
            set
            {
                filterText = value;
                if (filterChanged != null)
                    filterChanged();
                RaisePropertyChanged("FilterText");
            }
        }

        #endregion

        #region Properties

        public ObservableCollection<FileManager> ImageNodeInfo
        {
            get { return imageNodeInfo; }
            set { this.imageNodeInfo = value; }
        }


        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            var nodeImageInfo = new ObservableCollection<FileManager>();

            var doc = new FileManager() { FileName = "Documents" };
            var download = new FileManager() { FileName = "Downloads" };
            var mp3 = new FileManager() { FileName = "Music"};
            var pictures = new FileManager() { FileName = "Pictures" };
            var video = new FileManager() { FileName = "Videos" };

            var pollution = new FileManager() { FileName = "Environmental Pollution.docx", FileDescription = "Physical and biological components of the earth/atmosphere system to such an extent that normal environmental processes are adversely affected." };
            var globalWarming = new FileManager() { FileName = "Global Warming.ppt", FileDescription = "Global warming is a long-term rise in the average temperature of the Earth's climate system, an aspect of climate change shown by temperature measurements and by multiple effects of the warming. Though earlier geological periods also experienced episodes of warming, the term commonly refers to the observed and continuing increase in average air and ocean temperatures since 1900 caused mainly by emissions of greenhouse gases in the modern industrial economy" };
            var sanitation = new FileManager() { FileName = "Sanitation.docx", FileDescription = "Sanitation refers to public health conditions related to clean drinking water and adequate treatment and disposal of human excreta and sewage. Preventing human contact with feces is part of sanitation, as is hand washing with soap" };
            var socialNetwork = new FileManager() { FileName = "Social Network.pdf", FileDescription = "The social network perspective provides a set of methods for analyzing the structure of whole social entities as well as a variety of theories explaining the patterns observed in these structures"};
            var youthEmpower = new FileManager() { FileName = "Youth Empowerment.pdf", FileDescription = "Youth empowerment is a process where children and young people are encouraged to take charge of their lives. They do this by addressing their situation and then take action in order to improve their access to resources and transform their consciousness through their beliefs, values, and attitudes. Youth empowerment aims to improve quality of life. Youth empowerment is achieved through participation in youth empowerment programs. However scholars argue that children’s rights implementation should go beyond learning about formal rights and procedures to give birth to a concrete experience of rights. There are numerous models that youth empowerment programs use that help youth achieve empowerment."};

            var games = new FileManager() { FileName = "Game.exe", FileDescription = "A game is a structured form of play, usually undertaken for enjoyment and sometimes used as an educational tool. Games are distinct from work, which is usually carried out for remuneration, and from art, which is more often an expression of aesthetic or ideological elements"};
            var tutorials = new FileManager() { FileName = "Tutorials.zip", FileDescription = "A tutorial is a method of transferring knowledge and may be used as a part of a learning process. More interactive and specific than a book or a lecture, a tutorial seeks to teach by example and supply the information to complete a certain task." };
            var typeScript = new FileManager() { FileName = "TypeScript.7z", FileDescription = "Typescript(manuscript), a typed instance of a work"};
            var uiGuide = new FileManager() { FileName = "UI-Guide.pdf", FileDescription = "UI Designers Guide with useful resources, tools, tutorial and inspiration." };

            var song = new FileManager() { FileName = "Gouttes", FileDescription = "A song is a musical composition intended to be sung by the human voice." };

            var camera = new FileManager() { FileName = "Camera Roll", FileDescription = "Camera pictures" };
            var stone = new FileManager() { FileName = "Stone.jpg", FileDescription = "A stone is a mass of hard, compacted mineral."};
            var wind = new FileManager() { FileName = "Wind.jpg", FileDescription = "Wind is the flow of gases. Wind is mostly the movement of air."};

            var img0 = new FileManager() { FileName = "WIN_20160726_094117.JPG", FileDescription = "Image file" };
            var img1 = new FileManager() { FileName = "WIN_20160726_094118.JPG", FileDescription = "Image file" };

            var video1 = new FileManager() { FileName = "Naturals.mp4", FileDescription = "Video file- Experience the beauty of nature and relax with the peaceful sights and sounds of flowing rivers, trickling streams, still lakes, singing birds, flowers rocking in the wind and more"};
            var video2 = new FileManager() { FileName = "Wild.mpeg", FileDescription = "Video file -  Wild is a place for all things animals and for animal-lovers alike. Take a journey through the animal kingdom with us and discover things"};

            doc.SubFiles = new ObservableCollection<FileManager>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.SubFiles = new ObservableCollection<FileManager>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.SubFiles = new ObservableCollection<FileManager>
            {
                song
            };

            pictures.SubFiles = new ObservableCollection<FileManager>
            {
                camera,
                stone,
                wind
            };
            camera.SubFiles = new ObservableCollection<FileManager>
            {
                img0,
                img1
            };

            video.SubFiles = new ObservableCollection<FileManager>
            {
                video1,
                video2
            };

            Item = camera;
            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);
            imageNodeInfo = nodeImageInfo;
        }

        #endregion
    }
}
