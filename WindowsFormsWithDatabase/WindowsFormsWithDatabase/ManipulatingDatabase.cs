﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWithDatabase
{
    public class ManipulatingDatabase
    {

        public DataSet1 dataSet1;
        public DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        public DataSet1TableAdapters.ListsTableAdapter listsTableAdapter;
        public ManipulatingDatabase()
        {

        }

        /// <summary>
        /// Adding new row to Items table
        /// </summary>
        /// <param name="name"></param>
        /// <param name="listId"></param>
        public void addNewItemsRow(string name, byte listId)
        {
            itemsTableAdapter.Insert(name, listId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void addNewListsRow(string name)
        {
            listsTableAdapter.Insert(name);
        }

        public void editItemsRow(int id, string name)
        {
            DataSet1.ItemsRow ir = dataSet1.Items.FindById(id);
            ir.Name = name;
            itemsTableAdapter.Update(dataSet1);
        }


        public void editListsRow(byte id, string name)
        {
            DataSet1.ListsRow ir = dataSet1.Lists.FindById(id);
            ir.Name = name;
            listsTableAdapter.Update(dataSet1);
        }



        /// <summary>
        /// Removing item row
        /// </summary>
        /// <param name="id"></param>
        public void removeItemsRow(int id)
        {
            itemsTableAdapter.DeleteItemById(id);
        }

        /// <summary>
        /// Removing row from Lists table
        /// </summary>
        /// <param name="id"></param>

        public void removeListsRow(byte id)
        {
            listsTableAdapter.DeleteByListId(id);
        }
    }
}
