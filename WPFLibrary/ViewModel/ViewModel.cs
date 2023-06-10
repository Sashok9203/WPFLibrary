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
                new("Dorling Kindersley", 
                         "100 First Dinosaur Words",
                         "Help little dinosaur fans find all their favorite prehistoric friends! Meet the mighty Tyrannosaurus Rex, Giganotosaurus, Triceratops and many more... More than 40 amazing dinosaurs are clearly labelled, with helpful guides on how to pronounce their names, as well as other prehistoric creatures, dinosaur body parts, their eggs and babies, habitats and skeletons.",
                         "DK Children", 
                         new(2019, 2, 1)),
                new("Stephen King",
                         "11.22.63",
                         "WHAT IF you could travel back in time and change the course of history? WHAT IF you could change such a turning point as the assassination of John Kennedy? On November 22, 1963, John Kennedy was shot. However... King's hero, Jake Epping, is a school teacher in Lisbon Falls, Maine.",
                         "Hodder Paperbacks", 
                         new(2011, 11, 8)),
                new("Agatha Christie",
                         "Death on the Nile",
                         "Agatha Christie's most exotic murder mystery, reissued with a striking new cover designed to appeal to the latest generation of Agatha Christie fans and book lovers.The tranquillity of a cruise along the Nile is shattered by the discovery that Linnet Ridgeway has been shot through the head. She was young, stylish and beautiful, a girl who had everything - until she lost her life.",
                         "HarperCollins",
                         new(1937, 11, 1)),
                new("Ray Bradbury",
                         "Fahrenheit 451",
                         "A classic prophetic work about the near future, where books are burned by special power units of firefighters. Guy Montag is a fireman. His task is to burn books that are prohibited as a source of discord and misfortune. Although Guy himself is unhappy, his family is on the verge of breaking up, maybe the books are hidden in his house? The mechanical detective of the Fire Department tracks dissidents who, under the threat of lethal injection, call on the public to save and read books.",
                         "HarperVoyager", 
                         new(1953 , 7, 30)),
                new("Antoine de Saint-Exupery",
                         "The Little Prince",
                         "\"The Little Prince\" is a classic fairy tale that is equally loved by both adults and children. On the one hand, this is the story of the cosmic adventure of a little boy - the Little Prince, traveling from one planet to another, and on the other hand, it is a sobering allegory about the human state of mind. It was first published in 1943, an hour before the author had an accident. This translation contains magnificent illustrations by Saint-Exupéry.",
                         "Reynal & Hitchcock",
                         new(1945, 4, 3)),
                new("Winston Groom",
                         "Forrest Gump",
                         "Laugh, cry, jump up and applaud, because the story of Forrest Gump is the story and dream of every person. Incredibly warm, extremely ticklish and stomach-churningly funny \"story from the face of an idiot\", created with the sharp pen of a modern wizard. No one was spared, but no one was forgotten either. If you have ever lacked the need to spend your free time well, this book will suit you",
                         "Doubleday", 
                         new(1986, 8, 17)),
                new("Stephen Hawking",
                         "A Brief History of Time",
                         "Was there a beginning of time? Can time be turned back? Is the universe infinite, or does it still have limits? These are just some of the issues covered in the pages of the world-renowned masterpiece. Its author is a physicist and one of the most influential and great conditions in the history of mankind.",
                         "Bantam Dell Publishing Group", 
                         new(1988, 1, 22)),
                new("John Green",
                         "The Fault in Our Stars",
                         "Despite the miraculous result of the treatment, which stopped the development of the tumor and gave Hazel a few extra years, the end of her life path, as a result of the diagnosis, was always only a matter of time. But when Augustus Waters appears in a support group for children with cancer, Hazel's predictable story takes an unexpected turn.",
                         "Penguin Books", 
                         new(2012, 1, 10)),
                new("Frank Herbert",
                         "Dune",
                         "Long before \"The Matrix\", \"Star Wars\", before \"Ender's Game\" and \"Neuromancer\", there was already the story of \"Dune\", which in its time became the laureate of the Hugo and Nebula awards and received the recognition of the best novel in the fantasy genre. Melange, also known as \"spice\", is the most valuable and rare element in the universe.",
                         "Hodder Paperbacks",
                         new(1965, 8, 2)),
                new("George Orwell",
                         "1984",
                         "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. ",
                         "Wordsworth", 
                         new(1949, 8, 6))
            };
        }
    }
}
