﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSTParser.NDB
{
    public class NodeDataDTO
    {
        public List<BlockDataDTO> NodeData; 
        public Dictionary<ulong, NodeDataDTO> SubNodeData;
    }
}
