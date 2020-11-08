namespace task9
{
    public class CounterTerrorist : Character
    {
        //функция разминирования возвращает успех, если бомба была заложена
        public bool demine() {
            if (!Program.isBombPlanted)
                return false;
            Program.isBombPlanted = false;
            //считаем, что персонаж может разминировать бомбу и без набора сапера за большее время, но если он есть в снаряжении, то используем
            Outfits.Remove(Outfit.Набор_сапера);
            return true;
        }

        //красивый вывод информации о персонаже
        public override string ToString()
        {
            return $"Тип: Контртеррорист; {base.ToString()}";
        }
    }
}
