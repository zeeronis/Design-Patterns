namespace Bringe
{
    interface IdataObject<T>
    {
        void NextItem();
        void PrevItem();
        void AddItem(T item);
        void deleteItem(T item);
        T GetCurrentItem();
    }
}
