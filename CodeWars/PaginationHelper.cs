using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PaginationHelper<T>
    {
        private MagicBook<T> magicBook;
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            if (itemsPerPage <= 0) throw new ArgumentException("Can not have 0 or negative items per page");

            magicBook = new MagicBook<T>(itemsPerPage);
            for (int i = 0; i < collection.Count; i++)
            {
                magicBook.WriteEntry(i, collection[i]);
            }
        }
        public int ItemCount => magicBook.ItemCount;
        public int PageCount => magicBook.PageCount;

        public int PageItemCount(int pageIndex) => magicBook.GetItemsCountInAPage(pageIndex);

        public int PageIndex(int itemIndex) => magicBook.GetPageNumberByIndex(itemIndex);

    }
    internal class PageEntry<T>
    {
        // Fields
        internal T Item;
        internal int EntryID;

        // Constructor
        public PageEntry(int entryID, T item)
        {
            this.Item = item;
            this.EntryID = entryID;
        }

    }

    internal class Page<T>
    {
        // Fields
        internal int PageNumber;
        internal int PageSize;

        // Properties
        internal bool IsFull => entries.Count >= PageSize;
        internal List<PageEntry<T>> entries { get; }

        // Constructor
        public Page(int pageSize, int pageNumber)
        {
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            entries = new List<PageEntry<T>>();
        }

        // Methods
        internal void AddPageEntry(T entry, int originalIndex)
        {
            if (this.IsFull)
            {
                throw new ArgumentException("Page is Full");
            }
            entries.Add(new PageEntry<T>(originalIndex, entry));
        }

        // Should contain a property called is full bool
        // Field/ property page number
        // Property max item size
    }

    internal class MagicBook<T>
    {
        // Fields
        private List<Page<T>> pages;

        // Properties
        internal int PageCount => pages.Count();
        internal int ItemCount => pages.Sum(p => p.entries.Count);
        public int PageSize { get; }

        // Constructor
        public MagicBook(int pageSize)
        {
            PageSize = pageSize;
            pages = new List<Page<T>>();
        }

        // Methods
        internal void WriteEntry(int originalIndex, T item)
        {
            if (pages.Count == 0 || pages.Last().IsFull)
            {
                pages.Add(new Page<T>(PageSize, pages.Count + 1));
            }
            pages.Last().AddPageEntry(item, originalIndex);
        }

        public void WriteBulkEntry(int[] originalIndex, T[] item)
        {

            for (int i = 0; i < originalIndex.Length; i++)
            {
                this.WriteEntry(originalIndex[i], item[i]);
            }
        }

        internal int GetItemsCountInAPage(int pageNumber)
        {
            if (pageNumber < 0 || pageNumber > pages.Count-1)
            {
                return -1;
            }
            return pages[pageNumber].entries.Count;
        }

        internal int GetPageNumberByIndex(int originalIndex)
        {
            foreach (var page in pages)
            {
                foreach (var entry in page.entries)
                {
                    if (entry.EntryID == originalIndex)
                    {
                        return page.PageNumber;
                    }
                }
            }
            return -1;
        }

        // Constructor should know what type is going into book<T>
        // Should know max page size in constructor
        // Should be able to writeEntry(T)
        // Should be able to writeBulkEntry(T[])
        // Should have a PageCount method
        // Should have a PageItemCount that gets total number of items on page(int) -1 return if page does not exist
        // GetPageByIndex
    }
}

