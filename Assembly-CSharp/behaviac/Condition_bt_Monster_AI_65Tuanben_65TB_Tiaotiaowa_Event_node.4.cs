﻿using System;

namespace behaviac
{
	// Token: 0x02002D11 RID: 11537
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_65TB_Tiaotiaowa_Event_node13 : Condition
	{
		// Token: 0x06014310 RID: 82704 RVA: 0x00610B86 File Offset: 0x0060EF86
		public Condition_bt_Monster_AI_65Tuanben_65TB_Tiaotiaowa_Event_node13()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 96;
		}

		// Token: 0x06014311 RID: 82705 RVA: 0x00610BA4 File Offset: 0x0060EFA4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag != flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DCBD RID: 56509
		private BE_Target opl_p0;

		// Token: 0x0400DCBE RID: 56510
		private BE_Equal opl_p1;

		// Token: 0x0400DCBF RID: 56511
		private int opl_p2;
	}
}
