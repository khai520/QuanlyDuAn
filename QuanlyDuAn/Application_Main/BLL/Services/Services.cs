﻿using QuanLyDuAnBDS.DAL.Models;
using QuanLyDuAnBDS.DAL.Repositories;
using QuanLyDuAnBDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnBDS.BLL.Services
{
    public class Services
    {
        private DACDrepositories dACDrepositories = new();
        private DADDRepositories aDDRepositories = new();
        public List<AllDA> AllDACT(int Id)
        {
            AllDA all;
            List<AllDA> allDA = new();
            if (aDDRepositories.GetAllDaDD().Where(x => x.Idtk == Id).Count() > 0)
            {
                foreach (var item in aDDRepositories.GetAllDaDD().Where(x => x.Idtk == Id))
                {
                    all = new()
                    {
                        Idda = item.Idda,
                        TenDuAn = item.TenDuAn,
                        Gia = item.Gia,
                        Diachi = item.Diachi,
                        Dientich = item.Dientich,
                        Mota = item.Mota,
                        Idtk = item.Idtk,
                        TinhTrang = "Đã được duyêt"
                    };
                    allDA.Add(all);
                }
            }
            if (dACDrepositories.GetAllDACD().Where(x => x.Idtk == Id).Count() > 0)
            {
                foreach (var item in dACDrepositories.GetAllDACD().Where(x => x.Idtk == Id))
                {
                    all = new()
                    {
                        Idda = item.Idda,
                        TenDuAn = item.TenDuAn,
                        Gia = item.Gia,
                        Diachi = item.Diachi,
                        Dientich = item.Dientich,
                        Mota = item.Mota,
                        Idtk = item.Idtk,
                        TinhTrang = "Chưa được duyêt"
                    };
                    allDA.Add(all);
                }
            }
            return allDA;
        }
 
        public List<AllDA> Sapxep(DataGridView dgv_listdanhsach , int d , int Id, bool check)
        {
            int i = 1;
            AllDA all = new AllDA();
            List<AllDA> allDA = new();
            if (dgv_listdanhsach.Columns.Count == 9)
            {
                allDA = AllDACT(Id);
            }
            else
            {
                foreach (var item in aDDRepositories.GetAllDaDD())
                {
                    all = new()
                    {
                        Idda = item.Idda,
                        TenDuAn = item.TenDuAn,
                        Gia = item.Gia,
                        Diachi = item.Diachi,
                        Dientich = item.Dientich,
                        Mota = item.Mota,
                        Idtk = item.Idtk
                    };
                    allDA.Add(all);
                }
            }
            if (check)
            {
                if (d == 1)
                {
                    allDA = allDA.OrderBy(x => x.Idda).ToList();
                }
                else if (d == 2)
                {
                    allDA = allDA.OrderBy(x => x.TenDuAn).ToList();
                }
                else if (d == 3)
                {
                    allDA = allDA.OrderBy(x => x.Gia).ToList();
                }
                else if (d == 4)
                {
                    allDA = allDA.OrderBy(x => x.Diachi).ToList();
                }
                else if (d == 5)
                {
                    allDA = allDA.OrderBy(x => x.Dientich).ToList();
                }
                else if (d == 6)
                {
                    allDA = allDA.OrderBy(x => x.Mota).ToList();
                }
                else if (d == 7)
                {
                    allDA = allDA.OrderBy(x => x.Idtk).ToList();
                }
                else if (d == 8)
                {
                    allDA = allDA.OrderBy(x => x.TinhTrang).ToList();
                }
            }
            else
            {
                if (d == 1)
                {
                    allDA = allDA.OrderByDescending(x => x.Idda).ToList();
                }
                else if (d == 2)
                {
                    allDA = allDA.OrderByDescending(x => x.TenDuAn).ToList();
                }
                else if (d == 3)
                {
                    allDA = allDA.OrderByDescending(x => x.Gia).ToList();
                }
                else if (d == 4)
                {
                    allDA = allDA.OrderByDescending(x => x.Diachi).ToList();
                }
                else if (d == 5)
                {
                    allDA = allDA.OrderByDescending(x => x.Dientich).ToList();
                }
                else if (d == 6)
                {
                    allDA = allDA.OrderByDescending(x => x.Mota).ToList();
                }
                else if (d == 7)
                {
                    allDA = allDA.OrderByDescending(x => x.Idtk).ToList();
                }
                else if (d == 8)
                {
                    allDA = allDA.OrderByDescending(x => x.TinhTrang).ToList();
                }
            }
            
            return allDA;
        }
        public List<AllDA> AdDa()
        {
            AllDA all;
            List<AllDA> allDA = new();
            if (aDDRepositories.GetAllDaDD().Count() > 0)
            {
                foreach (var item in aDDRepositories.GetAllDaDD())
                {
                    all = new()
                    {
                        Idda = item.Idda,
                        TenDuAn = item.TenDuAn,
                        Gia = item.Gia,
                        Diachi = item.Diachi,
                        Dientich = item.Dientich,
                        Mota = item.Mota,
                        Idtk = item.Idtk,
                        TinhTrang = "Đã được duyêt"
                    };
                    allDA.Add(all);
                }
            }
            if (dACDrepositories.GetAllDACD().Count() > 0)
            {
                foreach (var item in dACDrepositories.GetAllDACD())
                {
                    all = new()
                    {
                        Idda = item.Idda,
                        TenDuAn = item.TenDuAn,
                        Gia = item.Gia,
                        Diachi = item.Diachi,
                        Dientich = item.Dientich,
                        Mota = item.Mota,
                        Idtk = item.Idtk,
                        TinhTrang = "Chưa được duyêt"
                    };
                    allDA.Add(all);
                }
            }
            return allDA;
        }
        public List<AllDA> Timkiem(string? Idda, string? Ten, string? Dc, string? dientich, string? gia, string? iddt, string? Mota)
        {
            var checkIdda = AdDa();
            try
            {
                if (Idda != "")
                {
                    checkIdda = checkIdda.Where(x => x.Idda == Convert.ToInt32(Idda)).ToList();
                }
                if (Ten != "")
                {
                    checkIdda = checkIdda.Where(x => x.TenDuAn.ToUpper().Contains(Ten.ToUpper())).ToList();
                }
                if (Dc != "")
                {
                    checkIdda = checkIdda.Where(x => x.Diachi.ToUpper().Contains(Dc.ToUpper())).ToList();
                }
                if (dientich != "")
                {
                    checkIdda = checkIdda.Where(x => x.Dientich == Convert.ToDouble(dientich)).ToList();
                }
                if (gia != "")
                {
                    checkIdda = checkIdda.Where(x => x.Gia == Convert.ToInt32(gia)).ToList();
                }
                if (iddt != "")
                {
                    checkIdda = checkIdda.Where(x => x.Idtk == Convert.ToInt32(iddt)).ToList();
                }
                if (Mota != "")
                {
                    checkIdda = checkIdda.Where(x => x.Mota.ToUpper().Contains(Mota.ToUpper())).ToList();
                }
                return checkIdda;
            }
            catch (Exception)
            {
                MessageBox.Show("Sai định dạng");
                return AdDa();
            }
        }
    }
}
