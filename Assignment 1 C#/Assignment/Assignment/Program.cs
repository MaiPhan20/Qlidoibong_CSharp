using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        //===========Khỏi tạo đối tượng list=========//
        List<Doi> listdoi = new List<Doi>();
        List<Lichthi> listlt = new List<Lichthi>();
        List<Ketqua> listkq = new List<Ketqua>();
        List<Ketqua> listthang = new List<Ketqua>();
        List<Ketqua> listthua = new List<Ketqua>();
        List<Ketqua> listhoa = new List<Ketqua>();

        //===============Quản lý danh sách===========//
        public void danhSach(List<Doi> list)
        {
            int n;
            do
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine("- 1. Xem danh sach doi bong.");
                Console.WriteLine("- 2. Cap nhat danh sach doi bong.");
                Console.WriteLine("- 3. Them moi mot doi bong.");
                Console.WriteLine("- 0. Tro ve menu chinh.");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        break;
                    case 1:
                        xemDanhSach(list);
                        break;
                    case 2:
                        capNhatDanhSach(list);
                        break;
                    case 3:
                        themMoi(list);
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai!");
                        break;
                }
            } while (n.CompareTo(0) != 0);
        }          //-Menu danh sách
        public List<Doi> themMoi(List<Doi> list)
        {
            string answer = "";
            do
            {
                Console.WriteLine("======Them moi mot doi bong=====");
                Console.Write("- Nhap ma doi: ");
                string maDoi = Console.ReadLine();
                Console.Write("- Nhap ten doi: ");
                string tenDoi = Console.ReadLine();
                Console.Write("- Nhap ten huan luyen vien: ");
                string tenHLV = Console.ReadLine();
                list.Add(new Doi(maDoi, tenDoi, tenHLV));
                Console.WriteLine("- Ban co muon tiep tuc? [Y/N]");
                answer = Console.ReadLine();
                answer = answer.ToLower();
            } while (answer.CompareTo("y") == 0);
            return list;
        }      //-Thêm mới đội
        public void capNhatDanhSach(List<Doi> list)
        {
            string answer = "";
            do
            {
                Console.WriteLine("======Cap nhat thong tin doi bong=====");
                Console.Write("- Nhap ma doi: ");
                string maDoi = Console.ReadLine();
                Console.Write("- Sua ten doi: ");
                string tenDoi = Console.ReadLine();
                Console.Write("- Sua ten huan luyen vien: ");
                string tenHLV = Console.ReadLine();
                Console.WriteLine("- Ban co muon cap nhat thong tin? [Y/N]");
                string update = Console.ReadLine();
                update = update.ToLower();
                //Update một item trong list
                if (update == "y")
                {
                    try
                    {
                        //Lấy vị trí của item trong list
                        int index = list.FindIndex(delegate(Doi dsd1)
                        {
                            return dsd1.Madoi.Equals(maDoi);
                        });
                        //Xóa item ở vị trí vừa tìm được
                        list.RemoveAt(index);
                        //Thêm vào list một item mới
                        list.Add(new Doi(maDoi, tenDoi, tenHLV));
                        Console.WriteLine("- Thong tin da duoc cap nhat thanh cong!");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("- Cap nhat khong thanh cong!");
                    }
                }

                Console.WriteLine("- Ban co muon tiep tuc? [Y/N]");
                answer = Console.ReadLine();
                answer = answer.ToLower();

            } while (answer.CompareTo("y") == 0);
            //Cap nhat xong hien thi Menu danh sach 2
            if (answer == "n")
            {
                danhSach2(list);
            }
        }   //-Cập nhật đội - hiển thị DS 2
        public void danhSach2(List<Doi> list)
        {
            int n;
            do
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine("- 1. Xem danh sach doi bong.");
                Console.WriteLine("- 2. Cap nhat danh sach doi bong.");
                Console.WriteLine("- 3. Them moi mot doi bong.");
                Console.WriteLine("- 4. Xem danh sach theo thu tu ma doi."); //Sort theo mã
                Console.WriteLine("- 5. Xem danh sach doi bong theo ten doi."); //Sort theo tên
                Console.WriteLine("- 0. Tro ve menu chinh.");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        break;
                    case 1:
                        xemDanhSach(list);
                        break;
                    case 2:
                        capNhatDanhSach(list);
                        break;
                    case 3:
                        themMoi(list);
                        break;
                    case 4:
                        xemTheoMa(list);
                        break;
                    case 5:
                        xemTheoTen(list);
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai!");
                        break;
                }
            } while (n.CompareTo(0) != 0); //CompareTo return 0 and 1
        }         //-DS 2
        public void xemDanhSach(List<Doi> list)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|   Ma doi   |   Ten doi   |  Huan luyen vien  |");
            Console.WriteLine("================================================");
            foreach (Doi dsd in list)
            {
                Console.WriteLine("\n   {0}    \t {1}   \t {2} ", dsd.Madoi, dsd.Tendoi, dsd.HLV);
            }
            Console.WriteLine("\n================================================");

        }       //-Xem đội
        public void xemTheoMa(List<Doi> list)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|   Ma doi   |   Ten doi   |  Huan luyen vien  |");
            Console.WriteLine("================================================");
            list.Sort(new CompareMaDoi());
            foreach (Doi dsd in list)
            {
                Console.WriteLine("\n   {0}    \t {1}   \t {2} ", dsd.Madoi, dsd.Tendoi, dsd.HLV);
            }
            Console.WriteLine("\n================================================");
        }         //-Sort theo mã - DS2
        public void xemTheoTen(List<Doi> list)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|   Ma doi   |   Ten doi   |  Huan luyen vien  |");
            Console.WriteLine("================================================");
            list.Sort(new CompareTenDoi());
            foreach (Doi dsd in list)
            {
                Console.WriteLine("\n   {0}    \t {1}   \t {2} ", dsd.Madoi, dsd.Tendoi, dsd.HLV);
            }
            Console.WriteLine("\n================================================");
        }        //-Sort theo tên - DS2
        
        //=============Quản lý lịch thi đấu===========//
        public void lichThi(List<Lichthi> list)
        {
            int n;
            do
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine("- 1. Xem lich thi dau.");
                Console.WriteLine("- 2. Cap nhat lich thi dau.");
                Console.WriteLine("- 3. Tao lich thi dau.");
                Console.WriteLine("- 0. Tro ve menu chinh.");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        break;
                    case 1:
                        xemLich(list);
                        break;
                    case 2:
                        capNhat(list,listkq);
                        break;
                    case 3:
                        taoLich(list);
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai!");
                        break;
                }
            } while (n.CompareTo(0) != 0); //CompareTo return 0 and 1
        }       //-Menu lịch thi
        public void taoLich(List<Lichthi> list)
        {
            int i = 1;
            String n;
            foreach (Lichthi dslt in list)
            {
                Console.WriteLine("- {0}. Tran: {1} vs {2}", i++, dslt.Doia, dslt.Doib);
            }
            do
            {
                string doia = "", doib="";

                Console.WriteLine("===============================");
                Console.Write("- Chon: ");
                int index = int.Parse(Console.ReadLine());
                index = index - 1;
                //Lấy ra vị trí trận đấu trong list lịch thi
                for (int j = 0; j < list.Count; j++)
                {
                    Lichthi values = list[j];
                    if (index == j)
                    {
                        list.RemoveAt(index); //Xóa item tại vị trí chọn
                        Console.WriteLine("- Tran: {0} vs {1}",values.Doia, values.Doib); //in ra màn hình tên trận đấu vừa chọn
                        doia = values.Doia;
                        doib = values.Doib;// Gán trận đấu trong list lịch thi vào biến tạm doia doib
                        break; // Bắt đầu xóa item nhưng đã gán vào biến tạm
                    }
                }

                Console.Write("- Ngay thi dau: ");
                string ngayThi = Console.ReadLine();
                Console.Write("- Gio thi dau: ");
                string gioThi = Console.ReadLine();
                Console.Write("- San thi dau: ");
                string sanThi = Console.ReadLine();
                //Lưu mới vào list khi đã đầy đủ thông tin
                list.Insert(index, new Lichthi() { Doia = doia, Doib = doib, Ngaythi = ngayThi, Giothi = gioThi, Santhi = sanThi });

                Console.WriteLine("Ban co muon tiep tuc? [Y/N]");
                n = Console.ReadLine();
                n = n.ToLower();
            } while (n.CompareTo("y") == 0);
        }       //-Thêm mứi lịch
        public void capNhat(List<Lichthi> listlt, List<Ketqua> listkq)
        {
            string n;
            int i = 1;
            do
            {
                Console.Write("- Tran {0}: ", i++);
                string doia = Console.ReadLine();
                Console.Write(" vs ");
                string doib = Console.ReadLine();

                Console.WriteLine("Ban co muon tiep tuc? [Y/N]");
                n = Console.ReadLine();
                n = n.ToLower();
                listlt.Add(new Lichthi() { Doia = doia, Doib = doib });
                listkq.Add(new Ketqua() { Doia=doia, Doib =doib});
            } while (n.CompareTo("y") == 0); //CompareTo return 0 and 1
        }       //-Cập nhật lịch
        public void xemLich(List<Lichthi> list)
        {
            Console.WriteLine("\n===========Lich Thi Dau==========");
            foreach (Lichthi dslt in list)
            {
                Console.WriteLine("\n| Tran: {0} vs {1}",dslt.Doia,dslt.Doib);
                Console.WriteLine("| Ngay thi dau: " + dslt.Ngaythi);
                Console.WriteLine("| gio thi: " + dslt.Giothi);
                Console.WriteLine("| San thi: " + dslt.Santhi);

            }
        }       //-Xem lịch
        
        //===========Quản lý kết quả thi đấu==========//
        public void ketQua(List<Ketqua> listkq)
        {
            int i = 1, exit;
            string answer, a="", b="";
            Console.WriteLine("==========Ket qua thi dau========");
            foreach (Ketqua kq in listkq)
            {
                Console.WriteLine("- {0}. {1} vs {2}",i++, kq.Doia, kq.Doib);
            }
            Console.WriteLine("- 0. Tro ve menu chinh");
            do{
                Console.WriteLine("Chon: ");
                int index = int.Parse(Console.ReadLine());
                     exit = index; //Nếu chọn 0 thì thoát vòng lặp
                     if (exit != 0) //Nếu chọn khác 0 thì nhập kết quả trận đấu
                     {
                         index = index - 1;
                         //Lấy ra vị trí trong list kết quả
                         for (int j = 0; j < listkq.Count; j++)
                         {
                             Ketqua values = listkq[j];
                             if (index == j)
                             {
                                 listkq.RemoveAt(index); //Xóa item tại vị trí chọn
                                 Console.WriteLine("- Tran: {0} vs {1}", values.Doia, values.Doib); //in ra màn hình tên trận đấu vừa chọn
                                 a = values.Doia;
                                 b = values.Doib;// Gán trận đấu vừa chọn vào biến tạm a b.
                                 break; // Bắt đầu xóa item nhưng đã lưu trận đấu
                             }
                         }

                         Console.Write("- Ket qua {0}: ", a);
                         String kq1 = Console.ReadLine();
                         Console.Write("- Ket qua {0}: ", b);
                         String kq2 = Console.ReadLine();
                         if (int.Parse(kq1) > int.Parse(kq2)) //Nếu 1 > 2 thì a thắng b thua
                         {
                             listthang.Add(new Ketqua() { Thang = 1, Doia = a });
                             listthua.Add(new Ketqua() { Thua = 1, Doib = b });
                         }
                         else if (int.Parse(kq1) < int.Parse(kq2)) // Nếu 1 < 2 thì a thua b thắng
                         {
                             listthang.Add(new Ketqua() { Thang = 1, Doia = b });
                             listthua.Add(new Ketqua() { Thua = 1, Doib = a });
                         }
                         else //  Nếu 1 = 2 thì a = b hòa
                         {
                             listhoa.Add(new Ketqua() { Hoa = 1, Doia = a, Doib = b });
                         }
                         listkq.Add(new Ketqua(a, b, kq1, kq2));
                         Console.WriteLine("Ban co muon tiep tuc? [Y/N]");
                         answer = Console.ReadLine();
                         answer = answer.ToLower();
                         if (answer != "y") //Nếu chọn y thì thóat vòng lặp
                         {
                             exit = 0;
                         }
                     }
            } while (exit.CompareTo(0) != 0);

        }
        public void thongKe(List<Doi> listdoi, List<Lichthi> listlt, List<Ketqua> listkq)
        {
            int diema=0, diemb=0, diemc=0;
            int  i=0, j=0;
                Console.WriteLine("=====================================================================");
                Console.WriteLine("| Ma doi | Ten doi           | Tran | Thang |  Hoa  |  Thua  | Diem |");
                Console.WriteLine("=====================================================================");
                
                foreach (Doi d in listdoi)
                {
                    i = i++;
                    if (listlt[i].Doia.Equals(d.Tendoi))
                    {

                        int tran1 = (from n2 in listlt where n2.Doib == d.Tendoi select n2).Count();
                        int tran2 = (from n1 in listlt where n1.Doia == d.Tendoi select n1).Count();
                        int tempTran = tran1 + tran2; //Trận
                        int thang1 = (from n2 in listthang where n2.Doib == d.Tendoi select n2).Count();
                        int thang2 = (from n1 in listthang where n1.Doia == d.Tendoi select n1).Count();
                        int tempThang = thang1 + thang2; //Thắng
                        int hoa1 = (from n2 in listhoa where n2.Doib == d.Tendoi select n2).Count();
                        int hoa2 = (from n1 in listhoa where n1.Doia == d.Tendoi select n1).Count();
                        int tempHoa = hoa1 + hoa2; //Hòa
                        int thua1 = (from n2 in listthua where n2.Doib == d.Tendoi select n2).Count();
                        int thua2 = (from n1 in listthua where n1.Doia == d.Tendoi select n1).Count();
                        int tempThua = thua1 + thua2; //Thua
                        int diem1 = (from n2 in listkq where n2.Doib == d.Tendoi select n2).Sum(item => int.Parse(item.kqB));
                        int diem2 = (from n1 in listkq where n1.Doia == d.Tendoi select n1).Sum(item => int.Parse(item.kqA));
                        int tempDiem = diem1 + diem2; //Diem
  
                        Console.WriteLine("  {0}\t  {1}\t\t{2}\t{3}\t{4}\t{5}\t{6}", d.Madoi, d.Tendoi, tempTran, tempThang, tempHoa, tempThua, tempDiem);
                    } 
                    else if (listlt[i].Doib.Equals(d.Tendoi))
                        {
                            int tran1 = (from n2 in listlt where n2.Doib == d.Tendoi select n2).Count();
                            int tran2 = (from n1 in listlt where n1.Doia == d.Tendoi select n1).Count();
                            int tempTran = tran1 + tran2; //Trận
                            int thang1 = (from n2 in listthang where n2.Doib == d.Tendoi select n2).Count();
                            int thang2 = (from n1 in listthang where n1.Doia == d.Tendoi select n1).Count();
                            int tempThang = thang1 + thang2; //Thắng
                            int hoa1 = (from n2 in listhoa where n2.Doib == d.Tendoi select n2).Count();
                            int hoa2 = (from n1 in listhoa where n1.Doia == d.Tendoi select n1).Count();
                            int tempHoa = hoa1 + hoa2; //Hòa
                            int thua1 = (from n2 in listthua where n2.Doib == d.Tendoi select n2).Count();
                            int thua2 = (from n1 in listthua where n1.Doia == d.Tendoi select n1).Count();
                            int tempThua = thua1 + thua2; //Thua
                            int diem1 = (from n2 in listkq where n2.Doib == d.Tendoi select n2).Sum(item => int.Parse(item.kqB));
                            int diem2 = (from n1 in listkq where n1.Doia == d.Tendoi select n1).Sum(item => int.Parse(item.kqA));
                            int tempDiem = diem1 + diem2; //Diem
                            Console.WriteLine("  {0}\t  {1}\t\t{2}\t{3}\t{4}\t{5}\t{6}", d.Madoi, d.Tendoi, tempTran, tempThang, tempHoa, tempThua, tempDiem);

                    }
                    else
                    {
                        int tran1 = (from n2 in listlt where n2.Doib == d.Tendoi select n2).Count();
                        int tran2 = (from n1 in listlt where n1.Doia == d.Tendoi select n1).Count();
                        int tempTran = tran1 + tran2; //Trận
                        int thang1 = (from n2 in listthang where n2.Doib == d.Tendoi select n2).Count();
                        int thang2 = (from n1 in listthang where n1.Doia == d.Tendoi select n1).Count();
                        int tempThang = thang1 + thang2; //Thắng
                        int hoa1 = (from n2 in listhoa where n2.Doib == d.Tendoi select n2).Count();
                        int hoa2 = (from n1 in listhoa where n1.Doia == d.Tendoi select n1).Count();
                        int tempHoa = hoa1 + hoa2; //Hòa
                        int thua1 = (from n2 in listthua where n2.Doib == d.Tendoi select n2).Count();
                        int thua2 = (from n1 in listthua where n1.Doia == d.Tendoi select n1).Count();
                        int tempThua = thua1 + thua2; //Thua
                        int diem1 = (from n2 in listkq where n2.Doib == d.Tendoi select n2).Sum(item => int.Parse(item.kqB));
                        int diem2 = (from n1 in listkq where n1.Doia == d.Tendoi select n1).Sum(item => int.Parse(item.kqA));
                        int tempDiem = diem1 + diem2; //Diem
                        Console.WriteLine("  {0}\t  {1}\t\t{2}\t{3}\t{4}\t{5}\t{6}", d.Madoi, d.Tendoi, tempTran, tempThang, tempHoa, tempThua, tempDiem);

                    }
                }
                Console.WriteLine("=====================================================================");
        }

        //==============Menu điều khiển chương trình và Main run====//
        public void menu()
        {
            int n;
            do
            {
                Console.WriteLine("\n--Chao mung den voi V-League 2016--");
                Console.WriteLine("- 1. Quan ly danh sach doi bong.");
                Console.WriteLine("- 2. Quan ly lich thi dau.");
                Console.WriteLine("- 3. Quan ly ket qua thi dau.");
                Console.WriteLine("- 4. Thong ke.");
                Console.WriteLine("- 0. Thoat.");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        Console.WriteLine("Da thoat khoi chuong trinh!");
                        break;
                    case 1:
                        danhSach(listdoi);
                        break;
                    case 2:
                        lichThi(listlt);
                        break;
                    case 3:
                        ketQua(listkq);
                        break;
                    case 4:
                        thongKe(listdoi, listlt, listkq);
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai");
                        break;
                }
            } while (n.Equals(0) != true); //Equals return true and false
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
            Console.Read();
        }
    }
}
        
