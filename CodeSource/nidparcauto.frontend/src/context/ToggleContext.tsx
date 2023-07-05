import { createContext } from "react";

export type toggleType = {
    toggle: boolean;
    setToggle: (value: boolean) => void
}

export const ToggleContext = createContext<toggleType | null>({
    toggle: true,
    setToggle: (value) => value
})