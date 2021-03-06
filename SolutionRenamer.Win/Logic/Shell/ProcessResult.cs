﻿namespace SolutionRenamer.Win.Logic.Shell
{
    public class ProcessResult
    {
        public ProcessResult(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; private set; }

        public string Message { get; private set; }
    }
}