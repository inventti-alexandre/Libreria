﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Seguridad
{
    public class LaPazPrincipal : IPrincipal
    {
        private LaPazIdentity _identity;

        public LaPazIdentity Identity
        {
            get { return _identity ?? new AnonymousIdentity(); }
            set { _identity = value; }
        }

        #region IPrincipal Members
        IIdentity IPrincipal.Identity
        {
            get { return this.Identity; }
        }

        public bool IsInRole(string role)
        {
            return _identity.Roles.Contains(role);
        }
        #endregion
    }
    
}
