﻿using System;

namespace behaviac
{
	// Token: 0x02002C70 RID: 11376
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Event_node15 : Condition
	{
		// Token: 0x060141D9 RID: 82393 RVA: 0x0060A7BF File Offset: 0x00608BBF
		public Condition_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_B_Event_node15()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.GreaterThanOrEqualTo;
			this.opl_p2 = 0.4f;
		}

		// Token: 0x060141DA RID: 82394 RVA: 0x0060A7E0 File Offset: 0x00608BE0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DB9C RID: 56220
		private HMType opl_p0;

		// Token: 0x0400DB9D RID: 56221
		private BE_Operation opl_p1;

		// Token: 0x0400DB9E RID: 56222
		private float opl_p2;
	}
}
