﻿using System;

namespace behaviac
{
	// Token: 0x02003214 RID: 12820
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Chapter9_9_7_BOSS_Kexila_Action_node17 : Condition
	{
		// Token: 0x06014CB2 RID: 85170 RVA: 0x0064361F File Offset: 0x00641A1F
		public Condition_bt_Monster_AI_Chapter9_9_7_BOSS_Kexila_Action_node17()
		{
			this.opl_p0 = 21558;
		}

		// Token: 0x06014CB3 RID: 85171 RVA: 0x00643634 File Offset: 0x00641A34
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E5F9 RID: 58873
		private int opl_p0;
	}
}
