﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsLab
{
   public class LokomotivTep : Lokomotiv
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия трубы
        /// </summary>
        public bool Truba { private set; get; }
        /// <summary>
        /// Признак наличия Предупреждений
        /// </summary>
        public bool Danger  { private set; get; }

        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес теплохода</param>
        /// <param name="mainColor">Основной цвет вагона</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="Truba">Труба</param>
        public LokomotivTep(int maxSpeed, float weight, Color mainColor, Color dopColor, bool truba, bool danger):
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Truba = truba;
            Danger = danger;
        }
        public LokomotivTep(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Truba = Convert.ToBoolean(strs[4]);
                Danger = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //Дорисуем трубу
            if (Truba)
            {
                g.DrawRectangle(pen, _startPosX + 65, _startPosY - 5, 8, 5);
                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 65, _startPosY - 5, 8, 5);
            }
            //Знаки предупреждения
            if (Danger)
            {
                Brush brYellow = new SolidBrush(Color.Yellow);
                g.FillEllipse(brYellow, _startPosX, _startPosY, 20, 20);
                g.FillEllipse(brYellow, _startPosX + 70, _startPosY, 20, 20);
            }
            //отрисуем сам локомотив
            base.DrawTransport(g);
            //отрисуем мостик
            Brush brRed = new SolidBrush(DopColor);
            g.FillRectangle(brRed, _startPosX, _startPosY + 30, 90, 8);

        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Truba + ";" + Danger;
        }
    }
}
