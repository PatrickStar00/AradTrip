﻿using System;

namespace behaviac
{
	// Token: 0x02003CD2 RID: 15570
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_KexilaXianshi_Boss_EVENT_hard_node89 : Condition
	{
		// Token: 0x06016146 RID: 90438 RVA: 0x006AC87F File Offset: 0x006AAC7F
		public Condition_bt_Monster_AI_Tuanben_hard_KexilaXianshi_Boss_EVENT_hard_node89()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 570106;
		}

		// Token: 0x06016147 RID: 90439 RVA: 0x006AC8A0 File Offset: 0x006AACA0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F9F7 RID: 63991
		private BE_Target opl_p0;

		// Token: 0x0400F9F8 RID: 63992
		private BE_Equal opl_p1;

		// Token: 0x0400F9F9 RID: 63993
		private int opl_p2;
	}
}
