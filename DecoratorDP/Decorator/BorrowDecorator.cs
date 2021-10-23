using DesignPatterns.DecoratorDP.Component;
namespace DesignPatterns.DecoratorDP.Decorator
{
    public abstract class BorrowDecorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        // Constructor
        public BorrowDecorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}