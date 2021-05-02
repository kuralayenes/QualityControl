using System;
using System.Collections.Generic;
using System.Text;

namespace QualityControl.Models
{
    class LoginRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the Mail.
        /// </summary>

        public string Mail { get; set; }

        /// <summary>
        ///     Gets or sets the Password.
        /// </summary>

        public string Password { get; set; }

        #endregion Public Properties
    }
}
