﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class Uidioma
    {
        public Hashtable obtenerHash(DataTable dtIn)
        {

            Hashtable htOut = new Hashtable();

            foreach (DataRow drIn in dtIn.Rows)
            {

                htOut.Add(drIn["componente"].ToString(), drIn["texto"].ToString());

            }

            return htOut;

        }
    }
}
