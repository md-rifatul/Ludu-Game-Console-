﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task

{
    public static class MainBoard
    {
        public static string PrintBoard()
        {

            string MainBoard = @"
############################################################################
#                             #{24}|{25}|{26}#  |                          #
#                             #----#----#----#  V       Conputer           #
#                             #{23}#{57}#{27}#                             #
#        -----------          #----#----#----#         -----------         #
#        |    |    |          #{22}#{58}#{28}#         | R1 | R2 |         #
#        -----------          #----#----#----#         -----------         #
#        |    |    |          #{21}#{59}#{29}#         | R3 | R4 |         #
#        -----------          #----#----#----#         -----------         #
#                             #{20}#{60}#{30}#                             #
#                             #----#----#----#                             #
# -->                         #{19}#{61}#{31}#                             #
###############################----#----#----###############################
#{13}|{14}|{15}|{16}|{17}|{18}|              |{32}|{33}|{34}|{35}|{36}|{37}#
#----##########################              ##########################----#
#{12}|    |    |    |    |    |       X      |    |    |    |    |    |{38}#
#----##########################              ##########################----#
#{11}|{10}|{9} |{8} |{7} |{6} |              |{44}|{43}|{42}|{41}|{40}|{39}#
###############################----#----#----###############################
#                             #{5} #{56}#{45}#                         <-- #
#                             #----#----#----#                             #
#           BLUE              #{4} #{55}#{46}#                             #
#                             #----#----#----#                             #
#        -----------          #{3} #{54}#{47}#        -----------          #
#        | B1 |B2 |           #----#----#----#        |    |    |          #
#        -----------          # {2}#{53}#{48}#        -----------          #
#        |B3 | B4 |           #----#----#----#        |    |    |          #
#        -----------          #{1} #{52}#{49}#        -----------          #
#                           ^ #----#----#----#                             #
#                           | #{0} |{51}|{50}#                             #
############################################################################";

            return MainBoard;


        }
    }
}

