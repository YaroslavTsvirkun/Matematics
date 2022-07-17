using System.Collections.Generic;

namespace Expansions
{
    public static class ExtensionList
    {
        public static void Update<T>(this List<T> list, T oldItem, T newItem) where T : class
        {
            var indexItem = list.FindIndex(x => x.GetHashCode() == oldItem.GetHashCode());

            list.Remove(oldItem);
            list.Insert(indexItem, newItem);
        }
    }
}