﻿using System;

namespace behaviac
{
	// Token: 0x02003E68 RID: 15976
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Xielong_Xielong_Event_yongshi_node10 : Condition
	{
		// Token: 0x06016454 RID: 91220 RVA: 0x006BBC3C File Offset: 0x006BA03C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			int shifangjineng = ((BTAgent)pAgent).shifangjineng2;
			int num = 0;
			bool flag = shifangjineng == num;
			return (!flag) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}
	}
}
