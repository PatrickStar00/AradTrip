﻿using System;

namespace behaviac
{
	// Token: 0x020038D4 RID: 14548
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_3_Meimeng_BOSS_Kexila_Action_node14 : Condition
	{
		// Token: 0x06015985 RID: 88453 RVA: 0x006850E3 File Offset: 0x006834E3
		public Condition_bt_Monster_AI_Tuanben_Chap_3_Meimeng_BOSS_Kexila_Action_node14()
		{
			this.opl_p0 = 21209;
		}

		// Token: 0x06015986 RID: 88454 RVA: 0x006850F8 File Offset: 0x006834F8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F33D RID: 62269
		private int opl_p0;
	}
}
