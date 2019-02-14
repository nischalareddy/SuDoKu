﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDoKu
{
    public partial class SuDoKu : Form
    {
        TextBox[,] Board = new TextBox[9, 9];

        public SuDoKu()
        {
            InitializeComponent();
            MapTextBoxToBoardReferences();
        }

        private void MapTextBoxToBoardReferences()
        {
            Board[0, 0] = tb_00;
            Board[0, 1] = tb_01;
            Board[0, 2] = tb_02;
            Board[1, 2] = tb_12;
            Board[1, 1] = tb_11;
            Board[1, 0] = tb_10;
            Board[2, 2] = tb_22;
            Board[2, 1] = tb_21;
            Board[2, 0] = tb_20;
            Board[2, 5] = tb_25;
            Board[2, 4] = tb_24;
            Board[2, 3] = tb_23;
            Board[1, 5] = tb_15;
            Board[1, 4] = tb_14;
            Board[1, 3] = tb_13;
            Board[0, 5] = tb_05;
            Board[0, 4] = tb_04;
            Board[0, 3] = tb_03;
            Board[2, 8] = tb_28;
            Board[2, 7] = tb_27;
            Board[2, 6] = tb_26;
            Board[1, 8] = tb_18;
            Board[1, 7] = tb_17;
            Board[1, 6] = tb_16;
            Board[0, 8] = tb_08;
            Board[0, 7] = tb_07;
            Board[0, 6] = tb_06;
            Board[5, 8] = tb_58;
            Board[5, 7] = tb_57;
            Board[5, 6] = tb_56;
            Board[4, 8] = tb_48;
            Board[4, 7] = tb_47;
            Board[4, 6] = tb_46;
            Board[3, 8] = tb_38;
            Board[3, 7] = tb_37;
            Board[3, 6] = tb_36;
            Board[5, 5] = tb_55;
            Board[5, 4] = tb_54;
            Board[5, 3] = tb_53;
            Board[4, 5] = tb_45;
            Board[4, 4] = tb_44;
            Board[4, 3] = tb_43;
            Board[3, 5] = tb_35;
            Board[3, 4] = tb_34;
            Board[3, 3] = tb_33;
            Board[5, 2] = tb_52;
            Board[5, 1] = tb_51;
            Board[5, 0] = tb_50;
            Board[4, 2] = tb_42;
            Board[4, 1] = tb_41;
            Board[4, 0] = tb_40;
            Board[3, 2] = tb_32;
            Board[3, 1] = tb_31;
            Board[3, 0] = tb_30;
            Board[8, 8] = tb_88;
            Board[8, 7] = tb_87;
            Board[8, 6] = tb_86;
            Board[7, 8] = tb_78;
            Board[7, 7] = tb_77;
            Board[7, 6] = tb_76;
            Board[6, 8] = tb_68;
            Board[6, 7] = tb_67;
            Board[6, 6] = tb_66;
            Board[8, 5] = tb_85;
            Board[8, 4] = tb_84;
            Board[8, 3] = tb_83;
            Board[7, 5] = tb_75;
            Board[7, 4] = tb_74;
            Board[7, 3] = tb_73;
            Board[6, 5] = tb_65;
            Board[6, 4] = tb_64;
            Board[6, 3] = tb_63;
            Board[8, 2] = tb_82;
            Board[8, 1] = tb_81;
            Board[8, 0] = tb_80;
            Board[7, 2] = tb_72;
            Board[7, 1] = tb_71;
            Board[7, 0] = tb_70;
            Board[6, 2] = tb_62;
            Board[6, 1] = tb_61;
            Board[6, 0] = tb_60;
        }
        
    }
}