using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMakerSingleton.Model;

namespace EventMakerSingleton.ViewModel
{
    class EventViewModel
    {
        public EventViewModel(EventCatalogSingleton catalog)
        {
            Eventcatalog = catalog;
        }

        public EventCatalogSingleton Eventcatalog { get; set; }
    }
}
