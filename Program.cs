using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;
using System.Threading.Tasks;
using System.Timers;
using System.Security.Authentication.ExtendedProtection;

namespace Final_Exam
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region rooms
            //List<Room> rooms = new List<Room>();
            //rooms.Add(new Room("start", "g1", "r1"));
            //string currentRoom = "start";
            Room[] room = new Room[215];
            room[0] = new Room("start", "g1", "g2", 0);
            room[1] = new Room("g1", "g2", "null", 1);
            room[2] = new Room("g2", "g3", "null", 2);
            room[3] = new Room("g3", "g4", "null", 3);
            room[4] = new Room("g4", "g5", "null", 4);
            room[5] = new Room("g5", "g6", "null", 5);
            room[6] = new Room("g6", "g7", "null", 6);
            room[7] = new Room("g7", "g8", "null", 7);
            room[8] = new Room("g8", "g9", "null", 8);
            room[9] = new Room("g9", "g10", "null", 9);
            room[10] = new Room("g10", "g11", "null", 10);
            room[11] = new Room("g11", "g12", "null", 11);
            room[12] = new Room("g12", "g13", "null", 12);
            room[13] = new Room("g13", "g14", "null", 13);
            room[14] = new Room("g14", "g15", "null", 14);
            room[15] = new Room("g15", "p1", "null", 15);
            room[16] = new Room("g16", "g17", "null", 16);
            room[17] = new Room("g17", "g18", "null", 17);
            room[18] = new Room("g18", "g19", "null", 18);
            room[19] = new Room("g19", "g20", "null", 19);
            room[20] = new Room("g20", "g21", "null", 20);
            room[21] = new Room("g21", "g22", "null", 21);
            room[22] = new Room("g22", "g23", "null", 22);
            room[23] = new Room("g23", "p2", "null", 23);
            room[24] = new Room("g24", "g25", "null", 24);
            room[25] = new Room("g25", "g26", "null", 25);
            room[26] = new Room("g26", "g27", "null", 26);
            room[27] = new Room("g27", "g28", "null", 27);
            room[28] = new Room("g28", "g29", "null", 28);
            room[29] = new Room("g29", "g30", "null", 29);
            room[30] = new Room("g30", "g31", "null", 30);
            room[31] = new Room("g31", "g32", "null", 31);
            room[32] = new Room("g32", "p3", "null", 32);
            room[33] = new Room("g33", "g34", "null", 33);
            room[34] = new Room("g34", "g35", "null", 34);
            room[35] = new Room("g35", "g36", "null", 35);
            room[36] = new Room("g36", "g37", "null", 36);
            room[37] = new Room("g37", "g38", "null", 37);
            room[38] = new Room("g38", "g39", "null", 38);
            room[39] = new Room("g39", "g40", "null", 39);
            room[40] = new Room("g40", "g41", "null", 40);
            room[41] = new Room("g41", "g42", "null", 41);
            room[42] = new Room("g42", "g43", "null", 42);
            room[43] = new Room("g43", "end", "null", 43);
            room[44] = new Room("a1", "a2", "null", 44);
            room[45] = new Room("a2", "a3", "null", 45);
            room[46] = new Room("a3", "a4", "null", 46);
            room[47] = new Room("a4", "a5", "null", 47);
            room[48] = new Room("a5", "a6", "null", 48);
            room[49] = new Room("a6	", "t1", "null", 49);
            room[50] = new Room("a7", "a8", "null", 50);
            room[51] = new Room("a8", "a9", "null", 51);
            room[52] = new Room("a9", "a10", "null", 52);
            room[53] = new Room("a10", "a11", "null", 53);
            room[54] = new Room("a11", "a12", "null", 54);
            room[55] = new Room("a12", "a13", "null", 55);
            room[56] = new Room("a13", "a14", "null", 56);
            room[57] = new Room("a14", "a15", "null", 57);
            room[58] = new Room("a15", "a16", "null", 58);
            room[59] = new Room("a16", "a17", "null", 59);
            room[60] = new Room("a17", "a18", "null", 60);
            room[61] = new Room("a18", "g24", "null", 61);
            room[62] = new Room("a19", "a20", "null", 62);
            room[63] = new Room("a20", "a21", "null", 63);
            room[64] = new Room("a21", "a22", "null", 64);
            room[65] = new Room("a22", "a23", "null", 65);
            room[66] = new Room("a23", "a24", "null", 66);
            room[67] = new Room("a24", "a25", "null", 67);
            room[68] = new Room("a25", "a26", "null", 68);
            room[69] = new Room("a26", "a27", "null", 69);
            room[70] = new Room("a27", "a28", "null", 70);
            room[71] = new Room("a28", "a29", "null", 71);
            room[72] = new Room("a29", "a30", "null", 72);
            room[73] = new Room("a30", "a31", "null", 73);
            room[74] = new Room("a31", "a32", "null", 74);
            room[75] = new Room("a32", "a33", "null", 75);
            room[76] = new Room("a33", "t3", "null", 76);
            room[77] = new Room("b1", "b2", "null", 77);
            room[78] = new Room("b2", "b3", "null", 78);
            room[79] = new Room("b3", "b4", "null", 79);
            room[80] = new Room("b4", "b5", "null", 80);
            room[81] = new Room("b5", "b6", "null", 81);
            room[82] = new Room("b6", "b7", "null", 82);
            room[83] = new Room("b7", "b8", "null", 83);
            room[84] = new Room("b8", "b9", "null", 84);
            room[85] = new Room("b9", "b10", "null", 85);
            room[86] = new Room("b10", "b11", "null", 86);
            room[87] = new Room("b11", "t1", "null", 87);
            room[88] = new Room("b12", "b13", "null", 88);
            room[89] = new Room("b13", "b14", "null", 89);
            room[90] = new Room("b14", "b15", "null", 90);
            room[91] = new Room("b15", "b16", "null", 91);
            room[92] = new Room("b16", "b17", "null", 92);
            room[93] = new Room("b17", "b18", "null", 93);
            room[94] = new Room("b18", "b19", "null", 94);
            room[95] = new Room("b19", "b20", "null", 95);
            room[96] = new Room("b20", "g24", "null", 96);
            room[97] = new Room("b21", "b22", "null", 97);
            room[98] = new Room("b22", "b23", "null", 98);
            room[99] = new Room("b23", "b24", "null", 99);
            room[100] = new Room("b24", "p4", "null", 100);
            room[101] = new Room("b25", "b26", "null", 101);
            room[102] = new Room("b26", "b27", "null", 102);
            room[103] = new Room("b27", "b28", "null", 103);
            room[104] = new Room("b28", "b29", "null", 104);
            room[105] = new Room("b29", "b30", "null", 105);
            room[106] = new Room("b30", "b31", "null", 106);
            room[107] = new Room("b31", "b32", "null", 107);
            room[108] = new Room("b32", "b33", "null", 108);
            room[109] = new Room("b33", "b34", "null", 109);
            room[110] = new Room("b34", "b35", "null", 110);
            room[111] = new Room("b35", "b36", "null", 111);
            room[112] = new Room("b36", "t3	", "null", 112);
            room[113] = new Room("c1", "c2", "null", 113);
            room[114] = new Room("c2", "c3", "null", 114);
            room[115] = new Room("c3", "c4", "null", 115);
            room[116] = new Room("c4", "c5", "null", 116);
            room[117] = new Room("c5", "c6", "null", 117);
            room[118] = new Room("c6", "c7", "null", 118);
            room[119] = new Room("c7", "c8", "null", 119);
            room[120] = new Room("c8", "c9", "null", 120);
            room[121] = new Room("c9", "c10", "null", 121);
            room[122] = new Room("c10", "c11", "null", 122);
            room[123] = new Room("c11", "c12", "null", 123);
            room[124] = new Room("c12", "c13", "null", 124);
            room[125] = new Room("c13", "c14", "null", 125);
            room[126] = new Room("c14", "c15", "null", 126);
            room[127] = new Room("c15", "c16", "null", 127);
            room[128] = new Room("c16", "c17", "null", 128);
            room[129] = new Room("c17", "c18", "null", 129);
            room[130] = new Room("c18", "c19", "null", 130);
            room[131] = new Room("c19", "c20", "null", 131);
            room[132] = new Room("c20", "c21", "null", 132);
            room[133] = new Room("c21", "end", "null", 133);
            room[134] = new Room("r1", "r2", "null", 134);
            room[135] = new Room("r2", "r3", "null", 135);
            room[136] = new Room("r3", "r4", "null", 136);
            room[137] = new Room("r4", "r5", "null", 137);
            room[138] = new Room("r5", "r6", "null", 138);
            room[139] = new Room("r6", "r7", "null", 139);
            room[140] = new Room("r7", "r8", "null", 140);
            room[141] = new Room("r8", "r9", "null", 141);
            room[142] = new Room("r9", "r10", "null", 142);
            room[143] = new Room("r10", "r11", "null", 143);
            room[144] = new Room("r11", "r12", "null", 144);
            room[145] = new Room("r12", "r13", "null", 145);
            room[146] = new Room("r13", "r14", "null", 146);
            room[147] = new Room("r14", "r15", "null", 147);
            room[148] = new Room("r15", "r16", "null", 148);
            room[149] = new Room("r16", "r17", "null", 149);
            room[150] = new Room("r17", "r18", "null", 150);
            room[151] = new Room("r18", "r19", "null", 151);
            room[152] = new Room("r19", "r20", "null", 152);
            room[153] = new Room("r20", "r21", "null", 153);
            room[154] = new Room("r21", "r22", "null", 154);
            room[155] = new Room("r22", "r23", "null", 155);
            room[156] = new Room("r23", "r24", "null", 156);
            room[157] = new Room("r24", "r25", "null", 157);
            room[158] = new Room("r25", "p5", "null", 158);
            room[159] = new Room("r26", "r27", "null", 159);
            room[160] = new Room("r27", "r28", "null", 160);
            room[161] = new Room("r28", "r29", "null", 161);
            room[162] = new Room("r29", "r30", "null", 162);
            room[163] = new Room("r30", "r31", "null", 163);
            room[164] = new Room("r31", "r32", "null", 164);
            room[165] = new Room("r32", "r33", "null", 165);
            room[166] = new Room("r33", "r34", "null", 166);
            room[167] = new Room("r34", "r35", "null", 167);
            room[168] = new Room("r35", "r36", "null", 168);
            room[169] = new Room("r36", "r37", "null", 169);
            room[170] = new Room("r37", "r38", "null", 170);
            room[171] = new Room("r38", "r39", "null", 171);
            room[172] = new Room("r39", "r40", "null", 172);
            room[173] = new Room("r40", "r41", "null", 173);
            room[174] = new Room("r41", "r42", "null", 174);
            room[175] = new Room("r42", "r43", "null", 175);
            room[176] = new Room("r43", "r44", "null", 176);
            room[177] = new Room("r44", "r45", "null", 177);
            room[178] = new Room("r45", "r46", "null", 178);
            room[179] = new Room("r46", "r47", "null", 179);
            room[180] = new Room("r47", "r48", "null", 180);
            room[181] = new Room("r48", "r49", "null", 181);
            room[182] = new Room("r49", "r50", "null", 182);
            room[183] = new Room("r50", "r51", "null", 183);
            room[184] = new Room("r51", "r52", "null", 184);
            room[185] = new Room("r52", "r53", "null", 185);
            room[186] = new Room("r53", "r54", "null", 186);
            room[187] = new Room("r54", "r55", "null", 187);
            room[188] = new Room("r55", "r56", "null", 188);
            room[189] = new Room("r56", "r57", "null", 189);
            room[190] = new Room("r57", "r58", "null", 190);
            room[191] = new Room("r58", "r59", "null", 191);
            room[192] = new Room("r59", "r60", "null", 192);
            room[193] = new Room("r60", "r61", "null", 193);
            room[194] = new Room("r61", "r62", "null", 194);
            room[195] = new Room("r62", "r63", "null", 195);
            room[196] = new Room("r63", "r64", "null", 196);
            room[197] = new Room("r64", "r65", "null", 197);
            room[198] = new Room("r65", "r66", "null", 198);
            room[199] = new Room("r66", "r67", "null", 199);
            room[200] = new Room("r67", "end", "null", 200);
            room[201] = new Room("o1", "o2", "null", 201);
            room[202] = new Room("o2", "o3", "null", 202);
            room[203] = new Room("o3", "o4", "null", 203);
            room[204] = new Room("o4", "o5", "null", 204);
            room[205] = new Room("o5", "t2", "null", 205);
            room[206] = new Room("p1", "a1", "b1", 206);
            room[207] = new Room("p2", "a7", "b12", 207);
            room[208] = new Room("p3", "a19", "b21", 208);
            room[209] = new Room("p4", "b25", "c1", 209);
            room[210] = new Room("p5", "r26", "o1", 210);
            room[211] = new Room("t1", "g16", "null", 211);
            room[212] = new Room("t2", "g25", "null", 212);
            room[213] = new Room("t3", "g33", "null", 213);
            room[214] = new Room("end", "null", "null", 214);
            #endregion
            int currentRoom = 0;
            string curRoom;
            string leader;
            string person2;
            string person3;
            string person4;
            int people = 4;
            int route = 0;
            int landmark = 0;
            double balance = 0.0;
            #region job
            int job = Start(1);
            if (job == 1)
            {
                balance = 2000;
            }
            if (job == 2)
            {
                balance = 800;
            }
            if (job == 3)
            {
                balance = 1200;
            }
            #endregion
            int yak = 0; //$50 for 1
            double food = 0; //25c a pound
            int date = 0;
            int healthref = 10;
            string health = "";
            int ammo = 0; //$5 Box of 30
            int clothes = 0; //$15 Set of clothes
            int bait = 0; //$5 10 worms
            int wheel = 0; //$10 for 1
            int axle = 0; //$10 for 1
            int tongue = 0; //$10 for 1
            int hullpatch = 0; //$10 for 1
            int sailpatch = 0; //$10 for 1
            int mastpatch = 0; //$10 for 1
            int win = 0; // 0 = still playing, 1 = lose, 2 = win
            #region Naming People
            Console.Clear();
            int leader1 = 0;
            int person22 = 0;
            int person33 = 0;
            int person44 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your leader's name?");
                leader = Console.ReadLine();
                if (leader != "")
                {
                    leader1 = 1;
                }
            } while (leader1 == 0);
            do
            {
                Console.Clear();
                Console.WriteLine("What is your second person's name?");
                person2 = Console.ReadLine();
                if (person2 != "")
                {
                    person22 = 1;
                }
            } while (person22 == 0);
            do
            {
                Console.Clear();
                Console.WriteLine("What is your third person's name?");
                person3 = Console.ReadLine();
                if (person3 != "")
                {
                    person33 = 1;
                }
            } while (person33 == 0);
            do
            {
                Console.Clear();
                Console.WriteLine("What is your fourth person's name?");
                person4 = Console.ReadLine();
                if (person4 != "")
                {
                    person44 = 1;
                }
            } while (person44 == 0);
            int namechange = 0;
            do
            {
                string corectname = "";
                int corectnme = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Are These Names Correct? (y/n)");
                    Console.WriteLine(leader);
                    Console.WriteLine(person2);
                    Console.WriteLine(person3);
                    Console.WriteLine(person4);
                    corectname = Console.ReadLine().ToUpper();
                    if (corectname == "Y" || corectname == "N")
                    {
                        corectnme = 1;
                    }
                } while (corectnme == 0);
                Console.Clear();
                string nmechange;
                int namechnge = 0;
                if (corectname == "N")
                {
                    do
                    {
                        leader1 = 0;
                        person22 = 0;
                        person33 = 0;
                        person44 = 0;
                        Console.Clear();
                        Console.WriteLine("What Name Would You Like To Change?");
                        Console.WriteLine("1: {0}", leader);
                        Console.WriteLine("2: {0}", person2);
                        Console.WriteLine("3: {0}", person3);
                        Console.WriteLine("4: {0}", person4);
                        nmechange = Console.ReadLine();
                        if (nmechange == "1")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("What Would You Like To Change It To?");
                                leader = Console.ReadLine();
                                if (leader != "")
                                {
                                    leader1 = 1;
                                }
                            } while (leader1 == 0);
                            namechnge = 1;
                        }
                        if (nmechange == "2")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("What Would You Like To Change It To?");
                                person2 = Console.ReadLine();
                                if (person2 != "")
                                {
                                    person22 = 1;
                                }
                            } while (person22 == 0);
                            namechnge = 1;
                        }
                        if (nmechange == "3")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("What Would You Like To Change It To?");
                                person3 = Console.ReadLine();
                                if (person3 != "")
                                {
                                    person33 = 1;
                                }
                            } while (person33 == 0);
                            namechnge = 1;
                        }
                        if (nmechange == "4")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("What Would You Like To Change It To?");
                                person4 = Console.ReadLine();
                                if (person4 != "")
                                {
                                    person44 = 1;
                                }
                                namechnge = 1;
                            } while (person44 == 0);
                        }
                    } while (namechnge == 0);
                }
                if (corectname == "Y")
                {
                    namechange = 1;
                }
            } while (namechange == 0);
            #endregion
            #region Choosing Route
            int rote = 0;
            string rout;
            do
            {
                Console.Clear();
                Console.WriteLine("It Is 1943 And You Are Leaving From Saga To Lintse Along The Tibetan Trail,\n" +
                    "There Are Two Routes On The Trail To Lintse and " +
                    "Before You Leave You Will Need To Choose One So You\nKnow What To Buy");
                Console.WriteLine("1: River Route");
                Console.WriteLine("2: Land Route");
                rout = Console.ReadLine();
                if (rout == "1")
                {
                    route = 1;
                    rote = 1;
                }
                if (rout == "2")
                {
                    route = 2;
                    rote = 1;
                }
            } while (rote == 0);
            #endregion
            if (route == 1)
            {
                currentRoom = 134;
                Console.Clear();
                Console.WriteLine("'Hey I'm Zene, I hear you're going to travel the Tibetan Trail. You'll need\n" +
                    "some supplies before you start traveling'");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You Will Need Yak To Pull Your Boat Across Land When Needed");
                Console.WriteLine("You Will Need Clothes To Stay Warm Along The Trail");
                Console.WriteLine("You Will Need Food For Energy To Travel The Trail");
                Console.WriteLine("You Will Need Bait To Fish For More Food");
                Console.WriteLine("You Will Need Spare Parts To Fix Your Boat");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                #region Shop
                int yakcost = 0;
                string shopowner = "Zene";
                double foodcost = 0;
                int clothescost = 0;
                int baitcost = 0;
                int partcost = 0;
                int hullcost = 0;
                int sailcost = 0;
                int mastcost = 0;
                double totalcost = 0;
                int a = 0;
                string shopick = "";
                do
                {
                    Console.Clear();
                    totalcost = yakcost + foodcost + clothescost + baitcost + partcost;
                    Console.WriteLine("{0}: 'Welcome To My Shop, What Would You Like To Buy?'", shopowner);
                    Console.WriteLine("1: yak .  .  .  .  .  .  .  .  .  .  {0:C}", yakcost);
                    Console.WriteLine("2: food.  .  .  .  .  .  .  .  .  .  {0:C}", foodcost);
                    Console.WriteLine("3: clothing  .  .  .  .  .  .  .  .  {0:C}", clothescost);
                    Console.WriteLine("4: bait.  .  .  .  .  .  .  .  .  .  {0:C}", baitcost);
                    Console.WriteLine("5: boat parts.  .  .  .  .  .  .  .  {0:C}", partcost);
                    Console.WriteLine("Balance: {0:C}  .  .  .  .  . Total: {1:C}", balance, totalcost);
                    Console.WriteLine("Leave: Exit Shop/Buy");
                    shopick = Console.ReadLine().ToUpper();
                    if (shopick == "1")
                    {
                        yakcost = Yak(shopowner);
                    }
                    if (shopick == "2")
                    {
                        foodcost = Food(shopowner);
                    }
                    if (shopick == "3")
                    {
                        clothescost = Clothe(shopowner);
                    }
                    if (shopick == "4")
                    {
                        baitcost = Bait(shopowner);
                    }
                    if (shopick == "5")
                    {
                        int hulcost = 0;
                        int salcost = 0;
                        int mascost = 0;
                        int ttalcost = 0;
                        int bb = 0;
                        do
                        {
                            Console.Clear();
                            string d = "";
                            string b = "";
                            ttalcost = hulcost + salcost + mascost;
                            Console.WriteLine("{0}: 'I sell boat patches for $10 each, which patch do you need?'", shopowner);
                            Console.WriteLine("1: Hull Patch .  .  .  .  .  .  .  .  .  {0:C}", hulcost);
                            Console.WriteLine("2: Sail Patch .  .  .  .  .  .  .  .  .  {0:C}", salcost);
                            Console.WriteLine("3: Mast Patch .  .  .  .  .  .  .  .  .  {0:C}", mascost);
                            Console.WriteLine("Press Enter To Go Back .  .  .  . Total: {0:C}", ttalcost);
                            d = Console.ReadLine().ToUpper();
                            if (d == "1")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", shopowner);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            hulcost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "2")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", shopowner);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            salcost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "3")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", a);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            mascost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "")
                            {
                                Console.Clear();
                                bb = 1;
                            }
                        } while (bb == 0);
                        hullcost = hulcost;
                        sailcost = salcost;
                        mastcost = mascost;
                        partcost = ttalcost;
                    }
                    if (shopick == "LEAVE")
                    {
                        int hh = 0;
                        if (yak == 0 && yakcost == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You Need Yak To Pull Your Boat");
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            hh = 1;
                        }
                        if (balance < totalcost && hh != 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Not Enough Funds");
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            hh = 1;
                        }
                        if (hh == 0)
                        {
                            Console.Clear();
                            a = 1;
                        }
                    }
                } while (a == 0);
                yak += (Addyak(yakcost));
                food += (Addfood(foodcost));
                clothes += (Addclothe(clothescost));
                bait += (Addbait(baitcost));
                hullpatch += (Addwheel(hullcost));
                sailpatch += (Addaxle(sailcost));
                mastpatch += (Addtongue(mastcost));
                balance = balance - totalcost;
                #endregion
            }
            if (route == 2)
            {
                currentRoom = 1;
                Console.Clear();
                Console.WriteLine("'Hey I'm Jed, I hear you're going to travel the Tibetan Trail. You'll need\n" +
                    "some supplies before you start traveling'");
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You Will Need Yak To Pull Your Wagon Along The Trail");
                Console.WriteLine("You Will Need Clothes To Stay Warm Along The Trail");
                Console.WriteLine("You Will Need Food For Energy To Travel The Trail");
                Console.WriteLine("You Will Need Ammunition To Hunt For More Food");
                Console.WriteLine("You Will Need Spare Parts To Fix Your Wagon");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                #region Shop
                int yakcost = 0;
                string shopowner = "Jed";
                double foodcost = 0;
                int clothescost = 0;
                int ammocost = 0;
                int partcost = 0;
                int wheelcost = 0;
                int axlecost = 0;
                int tonguecost = 0;
                double totalcost = 0;
                int a = 0;
                string shopick = "";
                do
                {
                    Console.Clear();
                    totalcost = yakcost + foodcost + clothescost + ammocost + partcost;
                    Console.WriteLine("{0}: 'Welcome To My Shop, What Would You Like To Buy?'",shopowner);
                    Console.WriteLine("1: yak .  .  .  .  .  .  .  .  .  .  {0:C}", yakcost);
                    Console.WriteLine("2: food.  .  .  .  .  .  .  .  .  .  {0:C}", foodcost);
                    Console.WriteLine("3: clothing  .  .  .  .  .  .  .  .  {0:C}", clothescost);
                    Console.WriteLine("4: ammuniton .  .  .  .  .  .  .  .  {0:C}", ammocost);
                    Console.WriteLine("5: wagon parts  .  .  .  .  .  .  .  {0:C}", partcost);
                    Console.WriteLine("Balance: {0:C}  .  .  .  .  . Total: {1:C}", balance, totalcost);
                    Console.WriteLine("Leave: Exit Shop/Buy");
                    shopick = Console.ReadLine().ToUpper();
                    if (shopick == "1")
                    {
                        yakcost = Yak(shopowner);
                    }
                    if (shopick == "2")
                    {
                        foodcost = Food(shopowner);
                    }
                    if (shopick == "3")
                    {
                        clothescost = Clothe(shopowner);
                    }
                    if (shopick == "4")
                    {
                        ammocost = Ammo(shopowner); 
                    }
                    if (shopick == "5")
                    {
                        int whelcost = 0;
                        int axecost = 0;
                        int toguecost = 0;
                        int ttalcost = 0;
                        int bb = 0;
                        do
                        {
                            Console.Clear();
                            string d = "";
                            string b = "";
                            ttalcost = axecost + whelcost + toguecost;
                            Console.WriteLine("{0}: 'I sell wagon parts for $10 each, which part do you need?'", shopowner);
                            Console.WriteLine("1: Wagon Wheel.  .  .  .  .  .  .  .  .  {0:C}", whelcost);
                            Console.WriteLine("2: Wagon Axle .  .  .  .  .  .  .  .  .  {0:C}", axecost);
                            Console.WriteLine("3: Wagon Tongue  .  .  .  .  .  .  .  .  {0:C}", toguecost);
                            Console.WriteLine("Press Enter To Go Back .  .  .  . Total: {0:C}", ttalcost);
                            d = Console.ReadLine();
                            if (d == "1")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", shopowner);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            whelcost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "2")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", shopowner);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            axecost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "3")
                            {
                                int gg = 0;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("{0}: 'How many do you need?' (Limit 3 Spare)", a);
                                    b = Console.ReadLine();
                                    if (int.TryParse(b, out int c) != false)
                                    {
                                        if (c == 0 || c == 1 || c == 2 || c == 3)
                                        {
                                            int hh = 10;
                                            var add = Convert.ToInt32(b);
                                            toguecost = add * hh;
                                            gg = 1;
                                        }
                                    }
                                } while (gg == 0);
                            }
                            if (d == "")
                            {
                                Console.Clear();
                                bb = 1;
                            }
                        } while (bb == 0);
                        wheelcost = whelcost;
                        axlecost = axecost;
                        tonguecost = toguecost;
                        partcost = ttalcost;
                    }
                    if (shopick == "LEAVE")
                    {
                        int hh = 0;
                        if (yak == 0 && yakcost == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You Need Yak To Pull Your Wagon");
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            hh = 1;
                        }
                        if (balance < totalcost && hh != 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Not Enough Funds");
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            hh = 1;
                        }
                        if (hh == 0)
                        {
                            Console.Clear();
                            a = 1;
                        }
                    }
                } while (a == 0);
                yak += (Addyak(yakcost));
                food += (Addfood(foodcost));
                clothes += (Addclothe(clothescost));
                ammo += (Addammo(ammocost));
                wheel += (Addwheel(wheelcost));
                axle += (Addaxle(axlecost));
                tongue += (Addtongue(tonguecost));
                balance = balance - totalcost;
                #endregion
                Console.Clear();
                Console.WriteLine("You're Now Ready To Travel The Trail");
                Console.WriteLine("Press 'Enter' To Continue");
                Console.ReadLine();
                #region G 1-15
                bool ff = true;
                landmark = 15;
                do
                {
                    string stop;
                   
                    Console.Clear();
                    healthref = HealthL(healthref, food, clothes, people);
                    health = Health(healthref, health);
                    food = FoodL(food, yak, people);
                    int bk = 0;
                    do
                    {
                        Console.WriteLine("Health: {0}", health);
                        Console.WriteLine("Food: {0} Pounds", food);
                        Console.WriteLine("Next Landmark: {0} moves", landmark);
                        landmark -= 1;
                        currentRoom += 1;
                        Console.WriteLine("Press 'Enter' To Move");
                        Console.WriteLine("1: To Stop");
                        stop = Console.ReadLine();
                        if (stop == "")
                        {
                            bk = 1;
                        }
                        int mk = 0;
                         
                        if (stop == "1")
                        {
                            do
                            {
                                stop = Stopping(stop);
                                if (stop == "1")
                                {
                                    mk = 1;
                                }
                                if (stop == "2")
                                {
                                    string oio = LSupplies(yak, food, clothes, ammo, wheel, axle, tongue);
                                }
                                if (stop == "3")
                                {
                                    food = Hunting(food, ammo);
                                    ammo = AmmoL(ammo);
                                }
                                if (landmark == 0)
                                {
                                    bk = 1;
                                }
                            } while (mk == 0);
                        }
                    } while (bk == 0);
                    if (landmark == 0)
                    {
                        ff = false;
                    }

                } while (ff == true);
                #endregion
                Console.WriteLine(currentRoom);
                Console.ReadLine();
            }
        }
        #region Start/Job
        public static int Start(int a)
        {
            int k = 0;
            Console.WriteLine("Tibetan Trail");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Many Types of People Can Travel The Tibetan Trail");
                Console.WriteLine("You Can Be A");
                Console.WriteLine("1: Banker");
                Console.WriteLine("2: Farmer");
                Console.WriteLine("3: Carpenter");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2" || choice =="3")
                {
                    k = 1;
                }
            } while (k == 0);
            if (choice == "1")
            {
                return 1;
            }
            else if (choice == "2")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        #endregion
        #region Buying Yak
        public static int Yak(string b)
        {
            int yakcost = 0;
            int bb = 0;
            do
            {
                Console.Clear();
                string a = "";
                Console.WriteLine("{0}: 'I sell yak $50 each, how many would you like?' (Limit 10)",b);
                a = Console.ReadLine();
                if (a == "0" || a == "1" || a == "2" || a == "3" || a == "4" ||
                    a == "5" || a == "6" || a == "7" || a == "8" || a == "9" || a == "10")
                {
                    int hh = 50;
                    var add = Convert.ToInt32(a);
                    yakcost = add * hh;
                    bb = 1;
                }
            } while (bb == 0);
            return yakcost;
        }
        #endregion
        #region Buying Food
        public static double Food(string b)
        {
            double foodcost = 0;
            int bb = 0;
            do
            {
                Console.Clear();
                string a = "";
                Console.WriteLine("{0}: 'I sell one pound of food for 25c each, how many would you like?'",b);
                a = Console.ReadLine();
                if (int.TryParse(a, out int c) != false)
                {
                    if (c >= 0)
                    {
                        double hh = 0.25;
                        var add = Convert.ToInt32(a);
                        foodcost = add * hh;
                        bb = 1;
                    }
                }
            } while (bb == 0);
            return foodcost;
        }
        #endregion
        #region Buying Clothes
        public static int Clothe(string a)
        {
            int clothescost = 0;
            int bb = 0;
            do
            {
                Console.Clear();
                string b = "";
                Console.WriteLine("{0}: 'I sell a set of clothes for $15 each, how many would you like?'",a);
                b = Console.ReadLine();
                if (int.TryParse(b, out int c) != false)
                {
                    if (c >= 0)
                    {
                        int hh = 15;
                        var add = Convert.ToInt32(b);
                        clothescost = add * hh;
                        bb = 1;
                    }
                }
            } while (bb == 0);
            return clothescost;
        }
        #endregion
        #region Buying Ammo
        public static int Ammo(string a)
        {
            int ammocost = 0;
            int bb = 0;
            do
            {
                Console.Clear();
                string b = "";
                Console.WriteLine("{0}: 'I sell a box of ammo (30 Bullets) for $5, how many would you like?'", a);
                b = Console.ReadLine();
                if (int.TryParse(b, out int c) != false)
                {
                    if (c >= 0)
                    {
                        int hh = 5;
                        var add = Convert.ToInt32(b);
                        ammocost = add * hh;
                        bb = 1;
                    }
                }
            } while (bb == 0);
            return ammocost;
        }
        #endregion
        #region Buying Bait
        public static int Bait(string a)
        {
            int ammocost = 0;
            int bb = 0;
            do
            {
                Console.Clear();
                string b = "";
                Console.WriteLine("{0}: 'I sell a container of worms (10 Worms) for $5, how many would you like?'", a);
                b = Console.ReadLine();
                if (int.TryParse(b, out int c) != false)
                {
                    if (c >= 0)
                    {
                        int hh = 5;
                        var add = Convert.ToInt32(b);
                        ammocost = add * hh;
                        bb = 1;
                    }
                }
            } while (bb == 0);
            return ammocost;
        }
        #endregion
        #region Yak Add
        public static int Addyak(int a)
        {
            int cost = 50;
            int yak = 0;
            yak = a / cost;
            return yak;
        }
        #endregion
        #region Food Add
        public static double Addfood(double a)
        {
            double cost = 0.25;
            double food = 0;
            food = a / cost;
            return food;
        }
        #endregion
        #region Clothes Add
        public static int Addclothe(int a)
        {
            int cost = 15;
            int clothe = 0;
            clothe = a / cost;
            return clothe;
        }
        #endregion
        #region Ammo Add
        public static int Addammo(int a)
        {
            int cost = 5;
            int ammo = 0;
            ammo = (a / cost) * 30;
            return ammo;
        }
        #endregion
        #region Bait Add
        public static int Addbait(int a)
        {
            int cost = 5;
            int ammo = 0;
            ammo = (a / cost) * 10;
            return ammo;
        }
        #endregion
        #region Add Wheel
        public static int Addwheel(int a)
        {
            int cost = 10;
            int wheel = 0;
            wheel = a / cost;
            return wheel;
        }
        #endregion
        #region Add Axle
        public static int Addaxle(int a)
        {
            int cost = 10;
            int axle = 0;
            axle = a / cost;
            return axle;
        }
        #endregion
        #region Add Tongue
        public static int Addtongue(int a)
        {
            int cost = 10;
            int tongue = 0;
            tongue = a / cost;
            return tongue;
        }
        #endregion
        #region Health
        public static string Health(int healthref, string health)
        {
            int a = 0;
            if (healthref == 10 || healthref == 9 || healthref == 8)
            {
                health = "Good";
            }
            if (healthref == 7 || healthref == 6 || healthref == 5)
            {
                health = "Fair";
            }
            if (healthref == 4 || healthref == 3 || healthref == 2)
            {
                health = "Poor";
            }
            if (healthref == 1 || healthref == 0)
            {
                health = "Bad";
            }
            return health;
        }
        #endregion
        #region HealthLoss
        public static int HealthL(int healthref, double food, int clothes, int people)
        {
            if (food > 0 && healthref != 10)
            {
                healthref += 1;
                if (healthref > 10)
                {
                    healthref = 10;
                }
            }
            if (clothes >= people && healthref != 10)
            {
                healthref += 1;
                if (healthref > 10)
                {
                    healthref = 10;
                }
            }
            if (food == 0)
            {
                healthref -= 1;
            }
            if (clothes < people)
            {
                healthref -= 1;
            }
            return healthref;
        }
        #endregion
        #region Food Loss
        public static double FoodL(double food, int yak, int people)
        {
            int a;
            int b;
            int c;
            a = yak * 5;
            b = people * 3;
            c = a + b;
            food = food - c;
            if (food < 0)
            {
                food = 0;
            }
            return food;
        }
        #endregion
        #region Stopping
        public static string Stopping(string a)
        {
            int b = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1: Continue On Trail");
                Console.WriteLine("2: Check Supplies");
                Console.WriteLine("3: Hunt");
                a = Console.ReadLine();
                if (a == "1" || a == "2" || a == "3")
                {
                    b = 1;
                }
            } while (b == 0);
            return a;
        }
        #endregion
        #region Hunting
        public static double Hunting(double food, int ammo)
        {
            Console.Clear();
            if (ammo == 0)
            {
                Console.WriteLine("No Ammo To Hunt With");
                Console.WriteLine("Press 'Enter' To Continue");
                Console.ReadLine();
                return food;
            }
            Random rnd = new Random();
            int luck = rnd.Next(1, 3);
            if (luck == 1)
            {
                Console.WriteLine("You Didn't Come Back With Any Food");
                Console.WriteLine("Press 'Enter' To Continue");
                Console.ReadLine();
                return food;
            }
            if (luck == 2)
            {
                int shoot = rnd.Next(1, 6);
                if (shoot == 1)
                {
                    int meat = rnd.Next(5,101);
                    food += meat;
                    Console.WriteLine("You Came Back With {0} Pounds Of Meat", meat);
                    Console.WriteLine("Press 'Enter' To Continue");
                    Console.ReadLine();
                    return food;
                }
                if (shoot == 2)
                {
                    int meat = rnd.Next(100,126);
                    food += meat;
                    Console.WriteLine("You Came Back With {0} Pounds Of Meat", meat);
                    Console.WriteLine("Press 'Enter' To Continue");
                    Console.ReadLine();
                    return food;
                }
                if (shoot == 3)
                {
                    int meat = rnd.Next(125,151);
                    food += meat;
                    Console.WriteLine("You Came Back With {0} Pounds Of Meat", meat);
                    Console.WriteLine("Press 'Enter' To Continue");
                    Console.ReadLine();
                    return food;
                }
                if (shoot == 4)
                {
                    int meat = rnd.Next(150,176);
                    food += meat;
                    Console.WriteLine("You Came Back With {0} Pounds Of Meat", meat);
                    Console.WriteLine("Press 'Enter' To Continue");
                    Console.ReadLine();
                    return food;
                }
                if (shoot == 5)
                {
                    int meat = rnd.Next(175,201);
                    food += meat;
                    Console.WriteLine("You Came Back With {0} Pounds Of Meat", meat);
                    Console.WriteLine("Press 'Enter' To Continue");
                    Console.ReadLine();
                    return food;
                }
            }
            return food;
        }
        #endregion
        #region Ammo Loss
        public static int AmmoL(int ammo)
        {
            Console.Clear();
            if (ammo == 0)
            {
                return ammo;
            }
            Random rnd = new Random();
            int amo = rnd.Next(1, 21);
            ammo -= amo;
            if (ammo < 0)
            {
                ammo = 0;
            }
            Console.WriteLine("You Used {0} Bullets", amo);
            Console.WriteLine("Press 'Enter' To Continue");
            Console.ReadLine();
            return ammo;
        }
        #endregion
        #region Land Supplies
        public static string LSupplies(int yak, double food, int clothes, int ammo, int wheel, int axle, int tongue)
        {
            string a = "";
            Console.Clear();
            Console.WriteLine("Yak: {0}",yak);
            Console.WriteLine("Food: {0}", food);
            Console.WriteLine("Clothes: {0}", clothes);
            Console.WriteLine("Ammo: {0}", ammo);
            Console.WriteLine("Wheels: {0}", wheel);
            Console.WriteLine("Axles: {0}", axle);
            Console.WriteLine("Tongues: {0}", tongue);
            Console.WriteLine("Press 'Enter' To Continue");
            Console.ReadLine();
            return a;
        }
        #endregion
        #region River Supplies
        public static string RSupplies(int yak, double food, int clothes, int bait, int hullpatch, int sailpatch, int mastpatch)
        {
            string a = "";
            Console.Clear();
            Console.WriteLine("Yak: {0}", yak);
            Console.WriteLine("Food: {0}", food);
            Console.WriteLine("Clothes: {0}", clothes);
            Console.WriteLine("Bait: {0}", bait);
            Console.WriteLine("Hull Patches: {0}", hullpatch);
            Console.WriteLine("Sail Patches: {0}", sailpatch);
            Console.WriteLine("Mast Patches: {0}", mastpatch);
            Console.WriteLine("Press 'Enter' To Continue");
            Console.ReadLine();
            return a;
        }
        #endregion
        #region Hash Stuff
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
    

