using practice2_srp.entities;

namespace practice2_srp.interfaces;

public interface IEmailSender
{
    public void SenderMail(EmailParams emailParams);
}