﻿namespace Listas.Interfaces
{
    public interface ImethodLists<T>
    {
        void Add(T? data);
        void Delete(T data);
        void Search(T data);
        bool Exist(T data);
        IEnumerable<T> Show();
        IEnumerable<T> ShowRevers();
        bool IsEmpty();
        void Clear();
    }
}