﻿using System;

namespace behaviac
{
	// Token: 0x0200222A RID: 8746
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fight_Swordman_Axiuluo_newveryhard_Action_node20 : Condition
	{
		// Token: 0x06012DDE RID: 77278 RVA: 0x0058EA1A File Offset: 0x0058CE1A
		public Condition_bt_AutoFight_AutoFight_Fight_Swordman_Axiuluo_newveryhard_Action_node20()
		{
			this.opl_p0 = 0.15f;
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x0058EA30 File Offset: 0x0058CE30
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C7D9 RID: 51161
		private float opl_p0;
	}
}
