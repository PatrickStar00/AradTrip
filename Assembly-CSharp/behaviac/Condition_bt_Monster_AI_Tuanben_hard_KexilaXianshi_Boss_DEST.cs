﻿using System;

namespace behaviac
{
	// Token: 0x02003CB1 RID: 15537
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_KexilaXianshi_Boss_DESTINATIONSELET_hard_node15 : Condition
	{
		// Token: 0x06016107 RID: 90375 RVA: 0x006ABD2B File Offset: 0x006AA12B
		public Condition_bt_Monster_AI_Tuanben_hard_KexilaXianshi_Boss_DESTINATIONSELET_hard_node15()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = 570105;
		}

		// Token: 0x06016108 RID: 90376 RVA: 0x006ABD4C File Offset: 0x006AA14C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F9AC RID: 63916
		private BE_Target opl_p0;

		// Token: 0x0400F9AD RID: 63917
		private BE_Equal opl_p1;

		// Token: 0x0400F9AE RID: 63918
		private int opl_p2;
	}
}
