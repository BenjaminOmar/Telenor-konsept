import React, {createContext, useState, useContext, ReactNode} from 'react';

interface HeaderContextProps {
  headerTitle: string;
  setHeaderTitle: (title: string) => void;
  showGoBack: boolean;
  setShowGoBack: (show: boolean) => void;
  handleGoBack?: () => void;
  setHandleGoBack: (fn?: () => void) => void;
}

const HeaderContext = createContext<HeaderContextProps | undefined>(undefined);

export const HeaderProvider: React.FC<{children: ReactNode}> = ({children}) => {
  const [headerTitle, setHeaderTitle] = useState('');
  const [showGoBack, setShowGoBack] = useState(false);
  const [handleGoBack, setHandleGoBack] = useState<(() => void) | undefined>(
    undefined,
  );

  return (
    <HeaderContext.Provider
      value={{
        headerTitle,
        setHeaderTitle,
        showGoBack,
        setShowGoBack,
        handleGoBack,
        setHandleGoBack,
      }}>
      {children}
    </HeaderContext.Provider>
  );
};

export const useHeader = (): HeaderContextProps => {
  const context = useContext(HeaderContext);
  if (!context) {
    throw new Error('ERROR');
  }
  return context;
};
