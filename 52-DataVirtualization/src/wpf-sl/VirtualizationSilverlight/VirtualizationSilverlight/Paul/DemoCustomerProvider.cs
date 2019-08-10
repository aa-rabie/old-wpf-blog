﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Threading;

namespace VirtualizationSilverlight
{
    /// <summary>
    /// Demo implementation of IItemsProvider returning dummy customer items after
    /// a pause to simulate network/disk latency.
    /// </summary>
    public class DemoCustomerProvider : IItemsProvider<PaulsCustomer>
    {
        private readonly int _count;
        private readonly int _fetchDelay;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoCustomerProvider"/> class.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="fetchDelay">The fetch delay.</param>
        public DemoCustomerProvider(int count, int fetchDelay)
        {
            _count = count;
            _fetchDelay = fetchDelay;
        }

        /// <summary>
        /// Fetches the total number of items available.
        /// </summary>
        /// <returns></returns>
        public int FetchCount()
        {
            Thread.Sleep(_fetchDelay);
            return _count;
        }

        /// <summary>
        /// Fetches a range of items.
        /// </summary>
        /// <param name="startIndex">The start index.</param>
        /// <param name="count">The number of items to fetch.</param>
        /// <returns></returns>
        public IList<PaulsCustomer> FetchRange(int startIndex, int count)
        {
            Thread.Sleep(_fetchDelay);

            List<PaulsCustomer> list = new List<PaulsCustomer>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                PaulsCustomer customer = new PaulsCustomer { Id = i, Name = "Customer " + i };
                list.Add(customer);
            }
            return list;
        }
    }
}
