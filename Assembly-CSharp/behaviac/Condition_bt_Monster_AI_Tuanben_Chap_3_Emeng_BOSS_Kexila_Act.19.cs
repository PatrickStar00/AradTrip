﻿using System;

namespace behaviac
{
	// Token: 0x02003853 RID: 14419
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node17 : Condition
	{
		// Token: 0x0601588C RID: 88204 RVA: 0x0067F717 File Offset: 0x0067DB17
		public Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node17()
		{
			this.opl_p0 = 21228;
		}

		// Token: 0x0601588D RID: 88205 RVA: 0x0067F72C File Offset: 0x0067DB2C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F244 RID: 62020
		private int opl_p0;
	}
}
