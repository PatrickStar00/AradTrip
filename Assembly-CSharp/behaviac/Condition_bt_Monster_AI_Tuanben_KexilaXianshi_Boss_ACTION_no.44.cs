﻿using System;

namespace behaviac
{
	// Token: 0x02003A70 RID: 14960
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node88 : Condition
	{
		// Token: 0x06015CA9 RID: 89257 RVA: 0x0069493B File Offset: 0x00692D3B
		public Condition_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node88()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = 570035;
		}

		// Token: 0x06015CAA RID: 89258 RVA: 0x0069495C File Offset: 0x00692D5C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F5DF RID: 62943
		private BE_Target opl_p0;

		// Token: 0x0400F5E0 RID: 62944
		private BE_Equal opl_p1;

		// Token: 0x0400F5E1 RID: 62945
		private int opl_p2;
	}
}
