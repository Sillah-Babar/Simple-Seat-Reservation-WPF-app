using System;
using System.Collections.Generic;
using System.Text;


namespace WpfAppProject
{
    class reservationSystem
    {
        public List<bool> reserved;
        public List<char> seats;
        public List<Personcs> people;
        static reservationSystem res;
        int size;

        static public reservationSystem GetInstance()
        {
            if (res == null)
            {
                res = new reservationSystem();
                res.reserved = new List<bool>();
                res.seats = new List<char>();
                res.people = new List<Personcs>();
                SerializeData.SerializeSave();
                res.GetData();

            }
            return res;
        }
        public void PrintNames()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].name);
            }
        }
        void GetData()
        {

            people = SerializeData.Deserialize();

            for (int i = 0; i < 26; i++)
            {

                reserved.Add(false);

            }
            for (int i = 0; i < people.Count; i++)
            {
                for (int j = 0; j < people[i].seats.Count; j++)
                {
                    reserved[people[i].seats[j]] = true;
                }
            }

            char ap = 'A';
            for (int i = 0; i < 26; i++)
            {
                seats.Add(ap);
                ap = (char)(ap + 1);


            }
        }
        /*

        void addData()
        {
            for (int i = 0; i < 26; i++)
            {
                reserved.Add(false);
            }
            Personcs obj = new Personcs();
            obj.name = "Sillah";
            obj.seats.Add(1);
            obj.seats.Add(2);
            obj.seats.Add(3);
            reserved[1] = true;
            reserved[2] = true;
            reserved[3] = true;

            people.Add(obj);

            obj = new Personcs();
            obj.name = "Louis";
            obj.seats.Add(4);
            obj.seats.Add(5);
            obj.seats.Add(6);
            reserved[4] = true;
            reserved[5] = true;
            reserved[6] = true;
            people.Add(obj);

            obj = new Personcs();
            obj.name = "Rehan";
            obj.seats.Add(25);
            obj.seats.Add(18);
            obj.seats.Add(7);
            reserved[25] = true;
            reserved[18] = true;
            reserved[7] = true;
            people.Add(obj);

            obj = new Personcs();
            obj.name = "Raheem";
            obj.seats.Add(17);
            reserved[17] = true;
            people.Add(obj);

            obj = new Personcs();
            obj.name = "Sam";
            obj.seats.Add(16);
            obj.seats.Add(15);
            reserved[16] = true;
            reserved[15] = true;
            people.Add(obj);

            obj = new Personcs();
            obj.name = "Zayn";
            obj.seats.Add(22);
            obj.seats.Add(21);
            reserved[22] = true;
            reserved[21] = true;
            people.Add(obj);
            char ap = 'A';
            for (int i = 0; i < 26; i++)
            {
                seats.Add(ap);
                ap = (char)(ap + 1);


            }
            size = 6;
            


            SortNames();
        }
        */

        public void LongSort()
        {
            for (int i = 0; i < people.Count; i++)
            {
                for (int j = i + 1; j < people.Count; j++)
                {


                    // Console.WriteLine(people[i].name);
                    //                  Console.WriteLine(people[j].name);

                    if (people[i].name.Length < people[j].name.Length)
                    {
                        Personcs tem = people[i];
                        people[i] = people[j];
                        people[j] = tem;
                    }
                }

            }

        }
        public List<char> SeatsNotReserved()
        {
            List<char> sea = new List<char>();
            for (int i = 0; i < reserved.Count; i++)
            {
                if (reserved[i] == false)
                {
                    sea.Add(seats[i]);
                }
            }
            return sea;
        }
        public void SortNames()
        {
            //        Console.WriteLine(people.Capacity);

            for (int i = 0; i < people.Count; i++)
            {
                for (int j = i + 1; j < people.Count; j++)
                {


                    // Console.WriteLine(people[i].name);
                    //                  Console.WriteLine(people[j].name);
                    char ap = people[i].name[0];
                    char op = people[j].name[0];
                    if (ap < op)
                    {
                        Personcs tem = people[i];
                        people[i] = people[j];
                        people[j] = tem;
                    }
                }

            }
            //PrintNames();
        }


    }
}
