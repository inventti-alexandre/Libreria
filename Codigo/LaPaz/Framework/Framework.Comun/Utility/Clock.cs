using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Comun.Utility
{
    /// <summary>
    /// Implements IClock using System.DateTime
    /// </summary>
    public class Clock : IClock
    {
        /// <summary>
        /// Gets the current time
        /// </summary>
        public DateTime Now
        {
            get { return DateTimeOffset.Now.LocalDateTime; }
        }
    }
}
