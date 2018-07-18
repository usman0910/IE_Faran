using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThemeEmbeding.Models.Enums
{
    public class ProjectEnums
    {
        public enum OrderStatus
        {
            NewOrder,
            InProgress,
            CanceledByUs,
            CanceledByClient,
            Completed
        };
    }
}