using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDelegate
{
    public class ListGog
    {
        /// <summary>
        ///获取狗集合，排好序的
        /// </summary>
        /// <returns></returns>
        public List<DogEntity> GetListDog()
        {
            List<DogEntity> list = new List<DogEntity>();
            list.Add(new DogEntity() { Age = 23, Name = "大狗" });
            list.Add(new DogEntity() { Age = 6, Name = "小狗" });
            list.Add(new DogEntity() { Age = 12, Name = "中狗" });
            list.Add(new DogEntity() { Age = 1, Name = "最小狗" });

            return list;
        }
    }
}
