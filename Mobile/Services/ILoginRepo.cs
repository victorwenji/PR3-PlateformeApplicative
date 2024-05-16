using Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Services
{
    public interface ILoginRepo
    {
        Task<Etudiant> Login(string email);
    }
}
