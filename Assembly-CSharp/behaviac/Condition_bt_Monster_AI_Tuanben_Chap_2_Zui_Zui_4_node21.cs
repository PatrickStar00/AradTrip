﻿using System;

namespace behaviac
{
	// Token: 0x0200381A RID: 14362
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Zui_4_node21 : Condition
	{
		// Token: 0x06015824 RID: 88100 RVA: 0x0067D9C4 File Offset: 0x0067BDC4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Conditon_IsDayTime();
			bool flag2 = true;
			bool flag3 = flag != flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}
	}
}
