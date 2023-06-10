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
                new("Author2", "Tile2", "sdfkl;kfhg;lsdkfhg;lksdhf;gklhsd;lfkhgl;sdkh \nsdklf sd;lk fh;lsdkfh ;lsgdkhf ;glksdh f;lgksdh /nf;lsdkhf g;lsdkfh ;ldksfh ;lkdsfh ;lkdshf ;kldshf ;ldshf; lsdhfl", "Publisher2", new(2002, 2, 21))
            };
        }
    }
}
