﻿using System;

namespace behaviac
{
	// Token: 0x020036A4 RID: 13988
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Monster_Jinshenzhidinggao_Monster_dinggao_event_node27 : Condition
	{
		// Token: 0x06015564 RID: 87396 RVA: 0x0066F957 File Offset: 0x0066DD57
		public Condition_bt_Monster_AI_Monster_Jinshenzhidinggao_Monster_dinggao_event_node27()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = BE_State.GRAPED;
		}

		// Token: 0x06015565 RID: 87397 RVA: 0x0066F974 File Offset: 0x0066DD74
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckState(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EF35 RID: 61237
		private BE_Target opl_p0;

		// Token: 0x0400EF36 RID: 61238
		private BE_Equal opl_p1;

		// Token: 0x0400EF37 RID: 61239
		private BE_State opl_p2;
	}
}
