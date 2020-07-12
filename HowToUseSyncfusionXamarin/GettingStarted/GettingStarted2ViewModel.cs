using System.Collections.Generic;

namespace HowToUseSyncfusionXamarin.GettingStarted
{
    public class GettingStarted2ViewModel
    {
        public List<Person> Data { get; set; }

        public GettingStarted2ViewModel()
        {
            Data = new List<Person>()
            {
                new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
            };
        }
    }
}
