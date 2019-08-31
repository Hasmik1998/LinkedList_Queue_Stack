namespace HW1
{
    public class DoublyNode <E>
    {
        public E element;

        public DoublyNode<E> next;
        public DoublyNode<E> previous;
        public DoublyNode(E element, DoublyNode<E> next, DoublyNode<E> previous)
        {
            this.element = element;
            this.next = next;
            this.previous = previous;
        }
    }
}