using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyota_cars
{
partial class itemsss
    {
       public static ObservableCollection<tour_data> GetTours(){
             
            var temp = new ObservableCollection<tour_data>();
            tour_data tour;
            tour = new tour_data
             //{    tour_image = "ms-appx:///Assets/1.jpg",
             //    tour_text = "Samsung",
             //    tour_description = "is the largest mobile phone maker in its home market of South Korea, and the third largest in the world. In addition to mobile phones and related devices, the company also manufacturers things such as televisions, cameras, and electronic components"
             //};
            //temp.Add(tour);
            //tour = new tour_data
            //{

            //    tour_text = "Samsung",
            //    tour_image = "ms-appx:///Assets/2.jpg",
            //    tour_description = "is the largest mobile phone maker in its home market of South Korea, and the third largest in the world. In addition to mobile phones and related devices, the company also manufacturers things such as televisions, cameras, and electronic components"
            //};
            // temp.Add(tour);
            //tour = new tour_data
              {
                tour_text = "LG",
                tour_image = "ms-appx:///Assets/3.jpg",
                tour_description = "is a South Korean company that manufactures mobile phones, as well as other devices such as televisions and home appliances. LG originally stood for Lucky Goldstar, but is now promoted as meaning Life's Good in the company's marketing campaigns."
            };
            temp.Add(tour);
            tour = new tour_data
            
              {
                tour_text = "LG",
                tour_image = "ms-appx:///Assets/4.jpg",
                tour_description = "is a South Korean company that manufactures mobile phones, as well as other devices such as televisions and home appliances. LG originally stood for Lucky Goldstar, but is now promoted as meaning Life's Good in the company's marketing campaigns."
            };
               temp.Add(tour);
            tour = new tour_data
              {
                tour_text = "LG",
                tour_image = "ms-appx:///Assets/5.jpg",
                tour_description = "is a South Korean company that manufactures mobile phones, as well as other devices such as televisions and home appliances. LG originally stood for Lucky Goldstar, but is now promoted as meaning Life's Good in the company's marketing campaigns."
            };
            temp.Add(tour);

            return temp;
        
        }
    }
    class tour_data
    {

        public string tour_image { get; set; }

        public string tour_text { get; set; }

        public string tour_description { get; set; }
    }
}
