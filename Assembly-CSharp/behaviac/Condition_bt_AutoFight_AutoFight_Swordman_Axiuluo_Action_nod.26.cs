﻿using System;

namespace behaviac
{
	// Token: 0x020028BA RID: 10426
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node44 : Condition
	{
		// Token: 0x06013AAE RID: 80558 RVA: 0x005DF622 File Offset: 0x005DDA22
		public Condition_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node44()
		{
			this.opl_p0 = 0.6f;
		}

		// Token: 0x06013AAF RID: 80559 RVA: 0x005DF638 File Offset: 0x005DDA38
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D50B RID: 54539
		private float opl_p0;
	}
}
