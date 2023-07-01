using LantaSystem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LantaSystem
{
    public partial class Processor
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }
    }
    public class Component1
    {
        public List<Processor> gds;
        public Component1()
        {
            gds = сomponent1();
        }

        public List<Processor> сomponent1()
        {
            List<Processor> processor = new List<Processor>();
            Processor buff;
            List<Processor> bdproc = DataBase.BaseModel.Processor.ToList();

            foreach (Processor proc in bdproc)
            {
                buff = new Processor();
                buff.ID_Processor = proc.ID_Processor;
                buff.Title_Processor = proc.Title_Processor;
                buff.Description_Processor = proc.Description_Processor;
                buff.Price_Processor = proc.Price_Processor;
                buff.ID_Compatibility = proc.ID_Compatibility;
                buff.ID_Type_Goods = proc.ID_Type_Goods;
                buff.ID_Firm = proc.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == proc.ID_Firm);
                buff.Firms = firm.Title_Firm;

                processor.Add(buff);
            }
            return processor;
        }
    }
    public partial class RAM
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }
    }
    public class Component2
    {
        public List<RAM> gds;
        public Component2()
        {
            gds = сomponent2();
        }

        public List<RAM> сomponent2()
        {
            List<RAM> rams = new List<RAM>();
            RAM buff;
            List<RAM> bdram = DataBase.BaseModel.RAM.ToList();

            foreach (RAM ram in bdram)
            {
                buff = new RAM();
                buff.ID_RAM = ram.ID_RAM;
                buff.Title_RAM = ram.Title_RAM;
                buff.Description_RAM = ram.Description_RAM;
                buff.Price_RAM = ram.Price_RAM;
                buff.ID_Compatibility = ram.ID_Compatibility;
                buff.ID_Type_Goods = ram.ID_Type_Goods;
                buff.ID_Firm = ram.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == ram.ID_Firm);
                buff.Firms = firm.Title_Firm;

                rams.Add(buff);
            }
            return rams;
        }
    }
    public partial class Video_card
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }
    }
    public class Component3
    {
        public List<Video_card> gds;
        public Component3()
        {
            gds = сomponent3();
        }

        public List<Video_card> сomponent3()
        {
            List<Video_card> vc = new List<Video_card>();
            Video_card buff;
            List<Video_card> bdvc = DataBase.BaseModel.Video_card.ToList();

            foreach (Video_card vic in bdvc)
            {
                buff = new Video_card();
                buff.ID_Video_card = vic.ID_Video_card;
                buff.Title_Video_card = vic.Title_Video_card;
                buff.Description_Video_card = vic.Description_Video_card;
                buff.Price_Video_card = vic.Price_Video_card;
                buff.ID_Compatibility = vic.ID_Compatibility;
                buff.ID_Type_Goods = vic.ID_Type_Goods;
                buff.ID_Firm = vic.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == vic.ID_Firm);
                buff.Firms = firm.Title_Firm;

                vc.Add(buff);
            }
            return vc;
        }
    }
    public partial class Power_unit
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }
    }
    public class Component4
    {
        public List<Power_unit> gds;
        public Component4()
        {
            gds = сomponent4();
        }

        public List<Power_unit> сomponent4()
        {
            List<Power_unit> pu = new List<Power_unit>();
            Power_unit buff;
            List<Power_unit> bdpu = DataBase.BaseModel.Power_unit.ToList();

            foreach (Power_unit pou in bdpu)
            {
                buff = new Power_unit();
                buff.ID_Power_unit = pou.ID_Power_unit;
                buff.Title_Power_unit = pou.Title_Power_unit;
                buff.Description_Power_unit = pou.Description_Power_unit;
                buff.Price_Power_unit = pou.Price_Power_unit;
                buff.ID_Compatibility = pou.ID_Compatibility;
                buff.ID_Type_Goods = pou.ID_Type_Goods;
                buff.ID_Firm = pou.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == pou.ID_Firm);
                buff.Firms = firm.Title_Firm;

                pu.Add(buff);
            }
            return pu;
        }
    }
    public partial class Motherboard
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set
            {
                firm = value;
            }
        }
    }

    public class Component5
    {
        public List<Motherboard> gds;
        public Component5()
        {
            gds = сomponent5();
        }

        public List<Motherboard> сomponent5()
        {
            List<Motherboard> mb = new List<Motherboard>();
            Motherboard buff;
            List<Motherboard> bdmb = DataBase.BaseModel.Motherboard.ToList();

            foreach (Motherboard mob in bdmb)
            {
                buff = new Motherboard();
                buff.ID_Motherboard = mob.ID_Motherboard;
                buff.Title_Motherboard = mob.Title_Motherboard;
                buff.Description_Motherboard = mob.Description_Motherboard;
                buff.Price_Motherboard = mob.Price_Motherboard;
                buff.ID_Compatibility = mob.ID_Compatibility;
                buff.ID_Type_Goods = mob.ID_Type_Goods;
                buff.ID_Firm = mob.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == mob.ID_Firm);
                buff.Firms = firm.Title_Firm;

                mb.Add(buff);
            }
            return mb;
        }
    }
    public partial class Corpus
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }
    }
    public class Component6
    {
        public List<Corpus> gds;
        public Component6()
        {
            gds = сomponent6();
        }

        public List<Corpus> сomponent6()
        {
            List<Corpus> cor = new List<Corpus>();
            Corpus buff;
            List<Corpus> bdcor = DataBase.BaseModel.Corpus.ToList();

            foreach (Corpus corpus in bdcor)
            {
                buff = new Corpus();
                buff.ID_Corpus = corpus.ID_Corpus;
                buff.Title_Corpus = corpus.Title_Corpus;
                buff.Description_Corpus = corpus.Description_Corpus;
                buff.Price_Corpus = corpus.Price_Corpus;
                buff.ID_Compatibility = corpus.ID_Compatibility;
                buff.ID_Type_Goods = corpus.ID_Type_Goods;
                buff.ID_Firm = corpus.ID_Firm;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == corpus.ID_Firm);
                buff.Firms = firm.Title_Firm;

                cor.Add(buff);
            }
            return cor;
        }
    }
    public partial class Disk
    {
        private string firm;

        public string Firms
        {
            get { return firm; }
            set { firm = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    public class Component7
    {
        public List<Disk> gds;
        public Component7()
        {
            gds = сomponent7();
        }

        public List<Disk> сomponent7()
        {
            List<Disk> disks = new List<Disk>();
            Disk buff;
            List<Disk> bddisk = DataBase.BaseModel.Disk.ToList();

            foreach (Disk disk in bddisk)
            {
                buff = new Disk();
                buff.ID_Disk = disk.ID_Disk;
                buff.Title_Disk = disk.Title_Disk;
                buff.Description_Disk = disk.Description_Disk;
                buff.Price_Disk = disk.Price_Disk;
                buff.ID_Compatibility = disk.ID_Compatibility;
                buff.ID_Type_Goods = disk.ID_Type_Goods;
                buff.ID_Firm = disk.ID_Firm;
                buff.ID_Type_Disk = disk.ID_Type_Disk;

                Firm firm = DataBase.BaseModel.Firm.FirstOrDefault(x => x.ID_Firm == disk.ID_Firm);
                buff.Firms = firm.Title_Firm;

                Type_Disk type_Disk = DataBase.BaseModel.Type_Disk.FirstOrDefault(x => x.ID_Type_Disk == disk.ID_Type_Disk);
                buff.Type = type_Disk.Title_Tipe_Disk;

                disks.Add(buff); 
            }
            return disks;
        }
    }
    public class CompatibilityOfGoods
    {
        public List<Compatibility> gds;
        public CompatibilityOfGoods()
        {
            gds = compatibilityOfGoods();
        }

        public List<Compatibility> compatibilityOfGoods()
        {
            List<Compatibility> comp = new List<Compatibility>();
            Compatibility buff;
            List<Compatibility> bdcomp = DataBase.BaseModel.Compatibility.ToList();

            foreach (Compatibility compotibility in bdcomp)
            {
                buff = new Compatibility();
                buff.ID_Compatibility = compotibility.ID_Compatibility;
                buff.Title_Compatibility = compotibility.Title_Compatibility;

                comp.Add(buff);
            }
            return comp;
        }
        public class Users
        {
            public List<User> usr;
            public Users()
            {
                usr = newuser();
            }

            public List<User> newuser()
            {
                List<User> users = new List<User>();
                User buff;
                List<User> bdusers = DataBase.BaseModel.User.ToList();

                foreach (User user in bdusers)
                {
                    buff = new User();
                    buff.ID_User = user.ID_User;
                    buff.Surname_User = user.Surname_User;
                    buff.Name_User = user.Name_User;
                    buff.Login_User = user.Login_User;
                    buff.Password_User = user.Password_User;
                    buff.Phone_User = user.Phone_User;
                    buff.Address_User = user.Address_User;
                    buff.ID_Role = user.ID_Role;
                    users.Add(buff);
                }
                return users;
            }
        }
    }
}
