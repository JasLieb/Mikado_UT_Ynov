using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ynov.TU.Mikado.Models;

namespace Ynov.TU.Mikado.Service
{
    public class BorrowService
    {
        //emprunt d'un media
        public bool BorrowMedia(int UserId, int MediaId)
        {
            Borrow borrow = new Borrow();
            borrow.UserId = UserId;
            borrow.MediaId = MediaId;
            borrow.BorrowDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));

            bool isBorrowAdded = DatabaseContext.getInstance().Add(borrow);
            return isBorrowAdded;
        }

    }
}
