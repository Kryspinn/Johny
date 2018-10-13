using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Warsztaty.ViewModel
{
    public class ContactViewModel
    {       
        [MaxLength(25)]
        public virtual string Name { get; set; }

        public virtual int Number { get; set; }

        public virtual string Email { get; set; }

        public virtual string Phone { get; set; }
    }
}
