﻿using System;

namespace behaviac
{
	// Token: 0x020039A0 RID: 14752
	[GeneratedTypeMetaInfo]
	internal class Compute_bt_Monster_AI_Tuanben_Feiyi2_Destination_node4 : Compute
	{
		// Token: 0x06015B15 RID: 88853 RVA: 0x0068D878 File Offset: 0x0068BC78
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			int bianshen = ((BTAgent)pAgent).bianshen;
			int num = 1;
			((BTAgent)pAgent).bianshen = bianshen + num;
			return result;
		}
	}
}
