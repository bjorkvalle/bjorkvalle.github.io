using bjorkvalle.UI.Components;
using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace bjorkvalle.client.Pages.Wedding2023
{
    public record ScheduleItem
    {
        public string When { get; set; }
        public string What { get; set; }
        public string Where { get; set; }
    }
}
