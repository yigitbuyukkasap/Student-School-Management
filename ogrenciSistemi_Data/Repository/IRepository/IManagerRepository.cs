
using ogrenciSistemi_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Data.Data.Repository.IRepository
{
    public interface IManagerRepository : IRepository<Manager>
    {
        void Update(Manager obj);
    }
}
