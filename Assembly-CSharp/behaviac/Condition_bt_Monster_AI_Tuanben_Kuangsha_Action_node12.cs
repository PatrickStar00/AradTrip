﻿using System;

namespace behaviac
{
	// Token: 0x02003ADC RID: 15068
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Kuangsha_Action_node12 : Condition
	{
		// Token: 0x06015D77 RID: 89463 RVA: 0x00698FC2 File Offset: 0x006973C2
		public Condition_bt_Monster_AI_Tuanben_Kuangsha_Action_node12()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 570141;
		}

		// Token: 0x06015D78 RID: 89464 RVA: 0x00698FE4 File Offset: 0x006973E4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F686 RID: 63110
		private BE_Target opl_p0;

		// Token: 0x0400F687 RID: 63111
		private BE_Equal opl_p1;

		// Token: 0x0400F688 RID: 63112
		private int opl_p2;
	}
}
