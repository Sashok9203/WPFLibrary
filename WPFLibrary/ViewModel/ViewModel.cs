using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLibrary.VM
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        private readonly ObservableCollection<Book> bookList;
        public IEnumerable<Book> BoolList => bookList;
        public Book SelectionBook { get; set; }
        public int SelectedIndex { get; set; }
        public bool prevBottonEnabled => SelectedIndex > 0;
        public bool nextBottonEnabled => SelectedIndex < bookList.Count-1;
        public ViewModel()
        {
            bookList = new()
            {
                new("Dorling Kindersley", "100 First Dinosaur Words", "Help little dinosaur fans find all their favorite prehistoric friends! Meet the mighty Tyrannosaurus Rex, Giganotosaurus, Triceratops and many more... More than 40 amazing dinosaurs are clearly labelled, with helpful guides on how to pronounce their names, as well as other prehistoric creatures, dinosaur body parts, their eggs and babies, habitats and skeletons.", "DK Children", new(2019, 2, 1)),
                new("Author 2", "Tile 2", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 2", new(2002, 2, 21)),
                new("Author 3", "Tile 3", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 3", new(2012, 12, 12)),
                new("Author 4", "Tile 4", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 4", new(2000, 7, 30)),
                new("Author 5", "Tile 5", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 5", new(2001, 2, 3)),
                new("Author 6", "Tile 6", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 6", new(2010, 8, 17)),
                new("Author 7", "Tile 7", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 7", new(2008, 1, 22)),
                new("Author 8", "Tile 8", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 8", new(2003, 1, 10)),
                new("Author 9", "Tile 9", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 9", new(1998, 5, 2)),
                new("Author 10", "Tile 10", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher 10", new(2002, 2, 9))


            };
        }
    }
}
