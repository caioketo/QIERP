﻿using QIERPDatabase;
using QIERPDatabase.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class Orcamento : ClasseBase
    {
        public BindingList<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public int Numero { get; set; }

        public double Total
        {
            get
            {
                double t = 0;
                foreach (Item item in Itens)
                {
                    t += item.Total;
                }
                return t;
            }
        }
        public string ClienteNome
        {
            get
            {
                if (Cliente != null && Cliente.Pessoa != null)
                {
                    return Cliente.Pessoa.Nome;
                }
                return "";
            }
        }

        public string VendedorNome
        {
            get
            {
                if (Vendedor != null && Vendedor.Pessoa != null)
                {
                    return Vendedor.Pessoa.Nome;
                }
                return "";
            }
        }

        public Orcamento()
        {
            Itens = new BindingList<Item>();
        }

    }
}
