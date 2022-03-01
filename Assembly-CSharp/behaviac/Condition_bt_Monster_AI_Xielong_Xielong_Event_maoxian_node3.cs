﻿using System;

namespace behaviac
{
	// Token: 0x02003E29 RID: 15913
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Xielong_Xielong_Event_maoxian_node3 : Condition
	{
		// Token: 0x060163D8 RID: 91096 RVA: 0x006B9912 File Offset: 0x006B7D12
		public Condition_bt_Monster_AI_Xielong_Xielong_Event_maoxian_node3()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThanOrEqualTo;
			this.opl_p2 = 0.75f;
		}

		// Token: 0x060163D9 RID: 91097 RVA: 0x006B9934 File Offset: 0x006B7D34
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FC3E RID: 64574
		private HMType opl_p0;

		// Token: 0x0400FC3F RID: 64575
		private BE_Operation opl_p1;

		// Token: 0x0400FC40 RID: 64576
		private float opl_p2;
	}
}
