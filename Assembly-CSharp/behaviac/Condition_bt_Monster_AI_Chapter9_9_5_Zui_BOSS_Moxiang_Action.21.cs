﻿using System;

namespace behaviac
{
	// Token: 0x020031B6 RID: 12726
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node83 : Condition
	{
		// Token: 0x06014BFF RID: 84991 RVA: 0x0063F8BB File Offset: 0x0063DCBB
		public Condition_bt_Monster_AI_Chapter9_9_5_Zui_BOSS_Moxiang_Action_node83()
		{
			this.opl_p0 = 21572;
		}

		// Token: 0x06014C00 RID: 84992 RVA: 0x0063F8D0 File Offset: 0x0063DCD0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E561 RID: 58721
		private int opl_p0;
	}
}
