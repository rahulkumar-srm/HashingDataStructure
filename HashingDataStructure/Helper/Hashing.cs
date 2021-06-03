using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingDataStructure.Helper
{
    internal class Hashing
    {
        internal Node[] Items { get; set; }

        internal int[] Keys { get; set; }

        public Hashing(int size)
        {
            Items = new Node[size];
            Keys = new int[size];
        }

        LinearLinkedList list = new LinearLinkedList();

        internal void ChainingInsert(int key)
        {
            int index = Hash(key, Items.Length);
            list.SortedInsert(ref Items[index], key);
        }

        internal bool LinerInsert(int key)
        {
            int index = LinerProbe(key);

            if(index == -1)
            {
                Console.WriteLine("No space available");
                return false;
            }

            Keys[index] = key;
            return true;
        }

        internal bool QuadraticInsert(int key)
        {
            int index = QuadraticProbe(key);

            if (index == -1)
            {
                Console.WriteLine("No space available");
                return false;
            }

            Keys[index] = key;
            return true;
        }

        internal int SearchChaining(int key)
        {
            Node node = list.Search(Items[Hash(key, Items.Length)], key);
            if (node != null)
            {
                return node.Data;
            }
            return -1;
        }

        internal int SearchLinearProbing(int key)
        {
            int index = Hash(key, Keys.Length);
            int i = 0;

            while(Keys[(index + i ) % Keys.Length] != key)
            {
                i++;

                if((index + i) % Keys.Length == index)
                {
                    return -1;
                }
            }

            return (index + i) % Keys.Length;
        }

        internal int SearchQuadraticProbing(int key)
        {
            int index = Hash(key, Keys.Length);
            int i = 0;

            while (Keys[(index + i * i) % Keys.Length] != key)
            {
                i++;

                if ((index + i * i) % Keys.Length == index)
                {
                    return -1;
                }
            }

            return (index + i * i) % Keys.Length;
        }

        private int Hash(int key, int size)
        {
            return key % size;
        }

        private int LinerProbe(int key)
        {
            int index = Hash(key, Keys.Length);
            int i = 0;

            while (Keys[(index + i) % Keys.Length] != 0)
            {
                i++;

                if ((index + i) % Keys.Length == index)
                {
                    return -1;
                }
            }

            return (index + i) % Keys.Length;
        }

        private int QuadraticProbe(int key)
        {
            int index = Hash(key, Keys.Length);
            int i = 0;

            while (Keys[(index + i * i) % Keys.Length] != 0)
            {
                i++;

                if ((index + i) % Keys.Length == index)
                {
                    return -1;
                }
            }

            return (index + i * i) % Keys.Length;
        }
    }
}   
